namespace Exphadis.Core.Contract.Dto;

using System.ComponentModel.DataAnnotations;

using Base;

using Enums;

public class PaymentCommitmentDto : AuditDto
{
    public int Id { get; set; }

    [Required]
    public int IdStudent { get; set; }

    [Required]
    public MoneyMovementTypeEnum IdMoneyMovement { get; set; }

    [Required]
    public MonthEnum Month { get; set; }

    [Required]
    public int Year { get; set; }

    [Required]
    public CommitmentStatusEnum IdStatus { get; set; }

    [Required]
    public DateTime Date { get; set; }

    public int IdPayment { get; set; }

    [Required]
    public decimal Amount { get; set; }

    public string Comment { get; set; }

    public string StudentName { get; set; }

    public string MoneyMovement { get; set; }

    public string MonthValue { get; set; }

    public string HavePayment { get; set; }

    public string StatusValue { get; set; }
}

public class PaymentCommitmentNotifyDto
{
    public DateTime Date { get; set; }

    public int PlusDays { get; set; }

    public CommitmentStatusEnum Status { get; set; }

    public IEnumerable<string> Numbers { get; set; }
}
