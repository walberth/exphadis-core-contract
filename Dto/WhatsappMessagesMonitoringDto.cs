namespace Exphadis.Core.Contract.Dto;

using Exphadis.Core.Contract.Enums;
using Exphadis.Core.Domain.WhatsappAggregates.Enum;

public sealed class WhatsappMessagesMonitoringFilterDto
{
    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public WhatsappDispatchBatchStatusEnum? Status { get; set; }

    public WhatsappMessageTypeEnum? MessageType { get; set; }

    public string RequestedBy { get; set; }

    public string Search { get; set; }

    public int Page { get; set; } = 1;

    public int PageSize { get; set; } = 20;
}

public sealed class WhatsappMessagesMonitoringResponseDto
{
    public WhatsappMessagesMonitoringKpiDto Kpis { get; set; }

    public List<WhatsappMessagesMonitoringTrendPointDto> Trend { get; set; } = new();

    public List<WhatsappMessagesMonitoringBreakdownDto> StatusBreakdown { get; set; } = new();

    public List<WhatsappMessagesMonitoringBreakdownDto> MessageTypeBreakdown { get; set; } = new();

    public List<WhatsappMessagesMonitoringBatchRowDto> Items { get; set; } = new();

    public int TotalCount { get; set; }
}

public sealed class WhatsappMessagesMonitoringKpiDto
{
    public int TotalBatches { get; set; }

    public int TotalRecipients { get; set; }

    public int TotalProcessed { get; set; }

    public int TotalSent { get; set; }

    public int TotalFailed { get; set; }

    public int TotalSkipped { get; set; }

    public decimal SuccessRate { get; set; }

    public int AverageProcessingSeconds { get; set; }

    public int CompletedWithErrorsBatches { get; set; }
}

public sealed class WhatsappMessagesMonitoringTrendPointDto
{
    public DateTime Date { get; set; }

    public int Total { get; set; }

    public int Sent { get; set; }

    public int Failed { get; set; }

    public int Skipped { get; set; }
}

public sealed class WhatsappMessagesMonitoringBreakdownDto
{
    public string Label { get; set; }

    public int Count { get; set; }

    public decimal Percentage { get; set; }
}

public sealed class WhatsappMessagesMonitoringBatchRowDto
{
    public string BatchId { get; set; }

    public string Title { get; set; }

    public string DeliveryChannel { get; set; }

    public string Status { get; set; }

    public string MessageType { get; set; }

    public string RequestedBy { get; set; }

    public DateTime AcceptedAt { get; set; }

    public DateTime? ScheduledFrom { get; set; }

    public DateTime? ScheduledTo { get; set; }

    public DateTime? ActivatedAt { get; set; }

    public DateTime? StartedAt { get; set; }

    public DateTime? FinishedAt { get; set; }

    public int TotalRecipients { get; set; }

    public int Processed { get; set; }

    public int Sent { get; set; }

    public int Failed { get; set; }

    public int Skipped { get; set; }

    public string ErrorSummary { get; set; }

    public int? NotificationId { get; set; }
}

public sealed class WhatsappMessagesMonitoringBatchDetailDto
{
    public WhatsappMessagesMonitoringBatchRowDto Batch { get; set; }

    public List<WhatsappMessagesMonitoringBatchContactDto> Contacts { get; set; } = new();
}

public sealed class WhatsappMessagesMonitoringBatchContactDto
{
    public string RecipientRef { get; set; }

    public string DisplayName { get; set; }

    public string PhoneNumber { get; set; }

    public string Status { get; set; }

    public string ErrorMessage { get; set; }
}
