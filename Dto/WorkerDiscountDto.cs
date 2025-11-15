namespace Exphadis.Core.Contract.Dto;

public class WorkerDiscountDto
{
    public int Id { get; set; }

    public int IdPerson { get; set; }

    public int IdWorker { get; set; }

    public int IdDiscount { get; set; }

    public int IdDiscountType { get; set; }

    public string DiscountType { get; set; }

    public int IdPeriodicityType { get; set; }

    public decimal Amount { get; set; }

    public decimal Percentage { get; set; }

    public int Month { get; set; }

    public int IdIncomeExpenses { get; set; }

    public int Year { get; set; }

    public string Detail { get; set; }

    public string CompleteName { get; set; }

    public string NameMonth { get; set; }

    public decimal RealAmount { get; set; }
}
