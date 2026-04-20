namespace Exphadis.Core.Contract.Dto
{
    public class WhatsAppWebQrDto
    {
        public bool Available { get; set; }

        public string QrDataUrl { get; set; } = string.Empty;

        public string QrRaw { get; set; }

        public long? ExpiresInMs { get; set; }
    }
}
