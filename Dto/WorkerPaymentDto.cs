namespace Exphadis.Core.Contract.Dto;

public class WorkerPaymentDto
{
    public int Id { get; set; }

    public int IdWorker { get; set; }

    public int IdPerson { get; set; }

    public int IdContractType { get; set; }

    public int IdPeriodicityType { get; set; }

    public int Year { get; set; }

    public int IdIncomeExpenses { get; set; }

    public decimal Amount { get; set; }

    public string Comment { get; set; }

    public string Month { get; set; }

    public int IdMonth { get; set; }

    public string CompleteName { get; set; }

    public PersonDto Person { get; set; }
}
