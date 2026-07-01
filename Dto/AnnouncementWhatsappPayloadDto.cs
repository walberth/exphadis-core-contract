namespace Exphadis.Core.Contract.Dto
{
    using System;
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

        /// <summary>
        /// Optional. Start of the scheduling window in UTC. When present, the batch is created
        /// in Scheduled status and only activated by the background worker once this instant is
        /// reached. The client is responsible for converting local time (America/Lima, UTC-5) to
        /// UTC before sending. If null, the batch is queued for immediate dispatch (legacy behaviour).
        /// </summary>
        public DateTime? ScheduledFrom { get; set; }

        /// <summary>
        /// Optional. End of the scheduling window in UTC. If the worker does not activate the batch
        /// before this instant (e.g. the service was down), the batch is marked Expired and not sent.
        /// Must be later than ScheduledFrom and cannot be provided without it.
        /// </summary>
        public DateTime? ScheduledTo { get; set; }
    }
}
