namespace Exphadis.Core.Contract.Dto
{
    public class WhatsappDispatchAcceptedResponseDto
    {
        public Guid BatchId { get; set; }

        public string Status { get; set; } = string.Empty;

        public DateTime AcceptedAt { get; set; }

        public int TotalRecipients { get; set; }

        public int? NotificationId { get; set; }
    }
}