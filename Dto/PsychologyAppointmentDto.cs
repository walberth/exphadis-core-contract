namespace Exphadis.Core.Contract.Dto;

using Base;

public class PsychologyAppointmentDto : AuditDto
{
    public int Id { get; set; }

    public int IdWorker { get; set; }

    public int IdStudent { get; set; }

    public DateTime AppointmentDate { get; set; }

    public bool Ended { get; set; }

    public string InternComment { get; set; }

    public string WorkerMessage { get; set; }

    public string AttorneyMessage { get; set; }

    public string Attachment { get; set; }

    public int MediaId { get; set; }
}
