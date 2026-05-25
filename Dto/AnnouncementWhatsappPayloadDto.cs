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

        public List<string> RecipientIds { get; set; } = new();
    }
}
