namespace Exphadis.Core.Contract.Dto
{
    public class EnrichRequestDto
    {
        public string Username { get; set; }
        public string Location { get; set; }
        public string CompleteName { get; set; }
        public string AppClientId { get; set; }
        public string SentryId { get; set; }
        public string QueryString { get; set; }
        public string RouteParams { get; set; }
        public string RequestBody { get; set; }
        public string TraceIdentifier { get; set; }
    }
}
