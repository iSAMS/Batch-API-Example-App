using System.Threading.Tasks;
using iSAMS.BatchAPI.Demo.Core.Data;
using iSAMS.BatchAPI.Demo.Core.DTOs;

namespace iSAMS.BatchAPI.Demo.Core.Services.Interfaces
{
    /// <summary>
    /// Service to provide data for and process API requests.
    /// </summary>
    public interface IRequestService
    {
        ///<summary>The currently available API endpoints.</summary>
        Endpoint[] Endpoints { get; set; }

        ///<summary>The currently available API versions.</summary>
        string[] Versions { get; set; }

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
        string BuildUrl(string host, string version, int endpointId, string apiKey, bool ssl);

        /// <summary>
        /// Makes a request to the API.
        /// </summary>
        /// <param name="requestData">The API request data.</param>
        /// <returns>
        /// An API response data object.
        /// </returns>
        Task<ApiResponseDto> MakeApiRequest(ApiRequestDto requestData);
    }
}