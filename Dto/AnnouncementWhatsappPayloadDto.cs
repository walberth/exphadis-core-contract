namespace Exphadis.Core.Contract.Dto
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    using Exphadis.Core.Contract.Enums;

    public class AnnouncementWhatsappPayloadDto
    {
        public WhatsappMessageTypeEnum MessageType { get; set; }

        public string? Text { get; set; }

        public string? StickerId { get; set; }

        public string? ImageUrl { get; set; }

        /// <summary>
        /// Radicale hrefs for direct contact resolution.
        /// Format: "admin/contacts/contact-id.vcf".
        /// </summary>
        public List<string> RecipientIds { get; set; } = new();

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? RecipientRefs { get; set; }
    }
}
