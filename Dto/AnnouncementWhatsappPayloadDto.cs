namespace Exphadis.Core.Contract.Dto
{
    using System.Collections.Generic;

    using Exphadis.Core.Contract.Enums;

    public class AnnouncementWhatsappPayloadDto
    {
        public WhatsappMessageTypeEnum MessageType { get; set; }

        public string? Text { get; set; }

        public string? StickerId { get; set; }

        public string? ImageUrl { get; set; }

        /// <summary>
        /// Legacy: contact IDs (deprecated in favor of RadicaleHrefs for direct resolution).
        /// </summary>
        public List<string> RecipientIds { get; set; } = new();

        /// <summary>
        /// Radicale hrefs for direct contact resolution. If provided, avoids full agenda scan.
        /// Format: "admin/contacts/contact-id.vcf". If empty, falls back to RecipientIds.
        /// </summary>
        public List<string> RadicaleHrefs { get; set; } = new();
    }
}
