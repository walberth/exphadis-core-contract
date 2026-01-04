// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Dto;

public class AssistanceDto
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int IdWorker { get; set; }

    public string Worker { get; set; }

    public int IdStudent { get; set; }

    public string Student { get; set; }

    public int IdEnrollment { get; set; }

    public bool Status { get; set; }

    public bool Justification { get; set; }
}

public class UploadAssistanceDto
{
    public string UserRegister { get; set; }

    [Required]
    public DateTime TimeRegister { get; set; }

    [Required]
    public AttachmentDto Attachment { get; set; }
}

public class WorkerAssistanceCsvDto
{
    public int AssistanceId { get; set; }

    public List<AssistanceCsvDto> AssistanceList = new();
}

public class AssistanceCsvDto
{
    public DateTime Date { get; set; }

    public string InHour { get; set; }

    public string OutHour { get; set; }

    public string WorkTime { get; set; }

    public string Note { get; set; }
}

public class AssistanceSummaryDto : AuditDto
{
    public int WorkerId { get; set; }

    public string CompleteName { get; set; }

    public string ContractType { get; set; }

    public int DelaysCount { get; set; }

    public int AbsencesCount { get; set; }

    public int DelaysTotalMinutes { get; set; }

    public int WorkerAssistanceSummaryId { get; set; }

    public bool JustifyAllowed { get; set; }
}

public class AssistanceDetailDto : AuditDto
{
    public int AssistanceId { get; set; }

    public DateTime Date { get; set; }

    public string DayOfWeek { get; set; }

    public string BaseEntryTime { get; set; }

    public string EntryTime { get; set; }

    public string DepartureTime { get; set; }

    public string Delay { get; set; }

    public int DelayMinutes { get; set; }

    public string IsDelayJustified { get; set; }

    public string Absence { get; set; }

    public string IsAbsenceJustified { get; set; }

    public string Comment { get; set; }

    public int JustificationId { get; set; }

    public int JustificationTypeId { get; set; }

    // NUEVO: datos para mostrar el ajuste aplicado
    public string DelayComparisonBaseTime { get; set; }

    public int? DelayMinutesDiscount { get; set; }
}

public class AssistanceJustificationDto : AuditDto
{
    public int Id { get; set; }

    public int AssistanceId { get; set; }

    public string Comment { get; set; }

    public int WorkerId { get; set; }

    public int WorkerJustifyingId { get; set; }

    public AssistanceJustificationTypeEnum JustificationTypeId { get; set; }

    // NUEVO:
    // - Cuando el tipo sea LessDelayMinutes, el front puede mandar cuántos minutos descontar.
    // - Debe ser >= 1.
    public int? DelayMinutesDiscount { get; set; }

    // NUEVO:
    // - Hora base contra la que se compara el ingreso (formato "HH:mm").
    // - Si no se envía, se usa la configuración AdmissionTime.
    public string DelayComparisonBaseTime { get; set; }
}
