namespace Exphadis.Core.Contract.Dto
{
    public class WhatsAppWebSendRequestDto
    {
        public string To { get; set; } = null!;

        public string Type { get; set; } = "text";

        public string Text { get; set; } = null!;
    }
}
