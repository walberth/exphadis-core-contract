namespace Exphadis.Core.Contract.Dto;

using Base;

public class PromotionTypeDto : AuditDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal Amount { get; set; }

    public decimal Percentage { get; set; }

    public int IdPeriodicity { get; set; }

    public int Year { get; set; }

    public int IdMoneyMovementType { get; set; }

    public string Periodicity { get; set; }
}
