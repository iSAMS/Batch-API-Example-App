using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iSAMS.BatchAPI.Demo.Core.Data;
using iSAMS.BatchAPI.Demo.Core.Services.Interfaces;
using Newtonsoft.Json;
using System.Net.Http;
using iSAMS.BatchAPI.Demo.Core.DTOs;
using iSAMS.BatchAPI.Demo.Core.Enumerations;

namespace iSAMS.BatchAPI.Demo.Core.Services.Implementations
{
    /// <summary>
    /// Service to provide data for and process API requests.
    /// </summary>
    public class RequestService : IRequestService
    {
        /// <summary>
        /// Request service constructor. Reads available API versions and endpoints from json config files. 
        /// </summary>
        public RequestService()
        {
            using (var file = File.OpenText($@"{AppDomain.CurrentDomain.BaseDirectory}\endpoints.json"))
            using (var sr = new StringReader(file.ReadToEnd()))
            using (var jr = new JsonTextReader(sr))
            {
                var js = new JsonSerializer();
                Endpoints = js.Deserialize<Endpoint[]>(jr);
            }
            using (var file = File.OpenText($@"{AppDomain.CurrentDomain.BaseDirectory}\apiversions.json"))
            using (var sr = new StringReader(file.ReadToEnd()))
            using (var jr = new JsonTextReader(sr))
            {
                var js = new JsonSerializer();
                Versions = js.Deserialize<string[]>(jr);
            }
        }

        ///<summary>The currently available API versions.</summary>
        public string[] Versions { get; set; }

        ///<summary>The currently available API endpoints.</summary>
        public Endpoint[] Endpoints { get; set; }

        /// <summary>
        /// Gets an endpoint's handler from its Id.
        /// </summary>
        /// <param name="endPointId">The endpoint's Id.</param>
        /// <returns>
        /// The endpoint's handler as a string.
        /// </returns>
        private string GetEndpointHandler(int endPointId)
        {
            return Endpoints.FirstOrDefault(e => e.Id == endPointId)?.Handler ?? string.Empty;
        }

        /// <summary>
        /// Builds the URL for an API request.
        /// </summary>
        /// <param name="host">The API host name.</param>
        /// <param name="version">The API version.</param>
        /// <param name="endpointId">The API endpoint Id.</param>
        /// <param name="apiKey">The API key.</param>
        /// <param name="ssl">Boolean value representing whether to use a secure connection to the API.</param>
        /// <returns>
        /// The URL as a string.
        /// </returns>
        public string BuildUrl(string host, string version, int endpointId, string apiKey, bool ssl)
        {
            var apiPath = new AppSettingsReader().GetValue("apiPath", typeof (string)).ToString();
            return
                $"http{(ssl ? "s" : string.Empty)}://{host}/{apiPath}/{version}/{GetEndpointHandler(endpointId)}?apiKey={{{apiKey}}}";
        }

        /// <summary>
        /// Processes an API response by populating an API response data object.
        /// </summary>
        /// <param name="response">The HTTP response message received from the API.</param>
        /// <returns>
        /// An API response data object.
        /// </returns>
        private static async Task<ApiResponseDto> ProcessApiResponse(HttpResponseMessage response)
        {
            var apiResponseDto = new ApiResponseDto
            {
                MediaType = response.Content.Headers.ContentType.MediaType,
                StatusCode = response.StatusCode
            };

            switch (apiResponseDto.MediaType)
            {
                case "application/zip":
                {
                    apiResponseDto.BinaryData = await response.Content.ReadAsByteArrayAsync();
                    apiResponseDto.FileName = response.Content.Headers.ContentDisposition.FileName;
                    break;
                }
                default:
                {
                    apiResponseDto.Xml = await response.Content.ReadAsStringAsync();
                    break;
                }
            }

            return apiResponseDto;
        }

        /// <summary>
        /// Makes a request to the API.
        /// </summary>
        /// <param name="requestData">The API request data.</param>
        /// <returns>
        /// An API response data object.
        /// </returns>
        public async Task<ApiResponseDto> MakeApiRequest(ApiRequestDto requestData)
        {
            var httpClient = new HttpClient();

            var url = BuildUrl(requestData.Host, requestData.Version, requestData.EndpointId, requestData.ApiKey,
                requestData.Ssl);

            switch (requestData.Verb)
            {
                case HttpVerb.Get:
                {
                    return await ProcessApiResponse(await httpClient.GetAsync(url));
                }
                case HttpVerb.Post:
                {
                    var httpContent = new StringContent(requestData.FilterXml, Encoding.UTF8, "application/xml");
                    return await ProcessApiResponse(await httpClient.PostAsync(url, httpContent));
                }
                default:
                {
                    throw new ArgumentException("Invalid HTTP Verb.");
                }
            }
        }
    }
}