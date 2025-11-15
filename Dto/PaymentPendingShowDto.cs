namespace Exphadis.Core.Contract.Dto;

public class PaymentPendingShowDto
{
    public int Id { get; set; }

    public string BankName { get; set; }

    public int IdBank { get; set; }

    public string Status { get; set; }

    public string OperationNumber { get; set; }

    public DateTime? OperationDate { get; set; }

    public DateTime? TimeRegister { get; set; }

    public string NamePersonRequested { get; set; }

    public int IdPerson { get; set; }

    public decimal Amount { get; set; }

    public decimal OriginalAmount { get; set; }

    public string ImageUrl { get; set; }

    public string Filtered { get; set; }
}
