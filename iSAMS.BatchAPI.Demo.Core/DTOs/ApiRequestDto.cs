using iSAMS.BatchAPI.Demo.Core.Enumerations;

namespace iSAMS.BatchAPI.Demo.Core.DTOs
{
    /// <summary>
    /// Represents the data required to make a request to the API.
    /// </summary>
    public class ApiRequestDto
    {
        public string Host { get; set; }
        public string ApiKey { get; set; }
        public HttpVerb Verb { get; set; }
        public int EndpointId { get; set; }
        public string Version { get; set; }
        public bool Ssl { get; set; }
        public string FilterXml { get; set; }
    }
}