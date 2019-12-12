namespace iSAMS.BatchAPI.Demo.Core.Data
{
    /// <summary>
    /// Represents an API endpoint.
    /// </summary>
    public class Endpoint
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Handler { get; set; }
    }
}