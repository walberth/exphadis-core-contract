namespace Exphadis.Core.Contract.Dto
{
    public class RadicaleContactDto
    {
        public string Id { get; set; } = string.Empty;

        public string RadicaleHref { get; set; } = string.Empty;

        public string DisplayName { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public bool WhatsappEnabled { get; set; }
    }
}
