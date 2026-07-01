namespace Exphadis.Core.Contract.Dto
{
    using System.Collections.Generic;

    public class WhatsappDispatchAcceptedResponseDto
    {
        public Guid BatchId { get; set; }

        public string Status { get; set; } = string.Empty;

        public DateTime AcceptedAt { get; set; }

        public int TotalRecipients { get; set; }

        public int? NotificationId { get; set; }

        public DateTime? ScheduledFrom { get; set; }

        public DateTime? ScheduledTo { get; set; }

        /// <summary>
        /// Recipients that were successfully added to the batch (valid phone + pending status).
        /// </summary>
        public List<AcceptedRecipient> Accepted { get; set; } = new();

        /// <summary>
        /// Recipients that were skipped (no phone, not found, or resolution error).
        /// </summary>
        public List<SkippedRecipient> Skipped { get; set; } = new();
    }

    /// <summary>
    /// Recipient successfully accepted for dispatch.
    /// </summary>
    public class AcceptedRecipient
    {
        public string RecipientId { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }

    /// <summary>
    /// Recipient that was skipped with a reason.
    /// </summary>
    public class SkippedRecipient
    {
        public string RecipientId { get; set; } = string.Empty;
        public string ErrorCode { get; set; } = string.Empty;
        public string ErrorMessage { get; set; } = string.Empty;
    }
}