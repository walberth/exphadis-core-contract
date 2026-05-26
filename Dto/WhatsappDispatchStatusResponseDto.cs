namespace Exphadis.Core.Contract.Dto
{
    public class WhatsappDispatchStatusResponseDto
    {
        public Guid BatchId { get; set; }

        public string Status { get; set; } = string.Empty;

        public int TotalRecipients { get; set; }

        public int Processed { get; set; }

        public int Sent { get; set; }

        public int Failed { get; set; }

        public int Skipped { get; set; }

        public DateTime AcceptedAt { get; set; }

        public DateTime? StartedAt { get; set; }

        public DateTime? FinishedAt { get; set; }

        public string? ErrorSummary { get; set; }

        public int? NotificationId { get; set; }
    }
}