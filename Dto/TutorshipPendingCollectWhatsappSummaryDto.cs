namespace Exphadis.Core.Contract.Dto;

public class TutorshipPendingCollectWhatsappSummaryDto
{
    public DateTime ExecutionDate { get; set; }

    public int Year { get; set; }

    public int MonthNumber { get; set; }

    public string MonthName { get; set; }

    public int TutorshipsEvaluated { get; set; }

    public int ReportsGenerated { get; set; }

    public int WhatsappMessagesSent { get; set; }

    public int TutorshipsWithoutDebtors { get; set; }

    public int TutorshipsWithoutMobile { get; set; }

    public int TutorshipsWithoutActiveContract { get; set; }

    public int FailedDeliveries { get; set; }

    public List<TutorshipPendingCollectWhatsappItemDto> Items { get; set; } = new List<TutorshipPendingCollectWhatsappItemDto>();
}

public class TutorshipPendingCollectWhatsappItemDto
{
    public int TutorshipId { get; set; }

    public int WorkerId { get; set; }

    public string WorkerName { get; set; }

    public string TutorshipLabel { get; set; }

    public string PhoneNumber { get; set; }

    public int DebtorStudents { get; set; }

    public string ReportUrl { get; set; }

    public string Status { get; set; }

    public string ErrorMessage { get; set; }
}