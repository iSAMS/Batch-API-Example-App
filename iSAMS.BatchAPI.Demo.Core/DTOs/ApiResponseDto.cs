using System.Net;

namespace iSAMS.BatchAPI.Demo.Core.DTOs
{
    /// <summary>
    /// Represents the data received from an API response.
    /// </summary>
    public class ApiResponseDto
    {
        public HttpStatusCode StatusCode { get; set; }
        public string MediaType { get; set; }
        public string Xml { get; set; }
        public byte[] BinaryData { get; set; }
        public string FileName { get; set; }
    }
}