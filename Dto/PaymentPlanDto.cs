namespace Exphadis.Core.Contract.Dto;

using Base;

public class StudentPaymentPlanDto : AuditDto
{
    public int Id { get; set; }

    public int IdLevel { get; set; }

    public string LevelType { get; set; }

    public decimal Pension { get; set; }

    public decimal Enrollment { get; set; }

    public decimal Material { get; set; }

    public decimal Interest { get; set; }

    public int Year { get; set; }

    public int PensionDay { get; set; }

    public bool Active { get; set; }
}
