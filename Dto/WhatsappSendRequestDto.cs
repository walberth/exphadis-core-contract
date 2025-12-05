namespace Exphadis.Core.Contract.Dto
{
    public class WhatsappSendRequestDto
    {
        public required string To { get; set; }
        public required string Template { get; set; }
        public required Dictionary<string, string> Parameters { get; set; }
    }
}
