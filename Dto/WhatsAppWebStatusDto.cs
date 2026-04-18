namespace Exphadis.Core.Contract.Dto
{
    public class WhatsAppWebStatusDto
    {
        public string Status { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string PushName { get; set; } = string.Empty;

        public long Uptime { get; set; }
    }
}
