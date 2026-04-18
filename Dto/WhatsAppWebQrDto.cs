namespace Exphadis.Core.Contract.Dto
{
    public class WhatsAppWebQrDto
    {
        public string QrDataUrl { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public long? ExpiresAt { get; set; }
    }
}
