namespace Exphadis.Core.Contract.Dto
{
    public class WhatsAppWebSendResponseDto
    {
        public string InternalMessageId { get; set; } = string.Empty;

        public string ProviderMessageId { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public string CorrelationId { get; set; } = string.Empty;
    }
}
