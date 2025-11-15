namespace Exphadis.Core.Contract.Dto;

public class PaymentFoundedByOperationNumberDto
{
    public int Id { get; set; }

    public string StudentName { get; set; }

    public string PersonName { get; set; }

    public string BankName { get; set; }

    public string OperationNumber { get; set; }

    public DateTime? OperationDate { get; set; }

    public DateTime? TimeRegister { get; set; }

    public string UserRegister { get; set; }

    public string WhereFinded { get; set; }

    public string Status { get; set; }
}
