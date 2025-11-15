namespace Exphadis.Core.Contract.Dto;

public class EgressDto : AuditDto
{
    public int Id { get; set; }

    public MoneyMovementTypeEnum EgressTypeId { get; set; }

    public PettyCashTypeEnum PettyCashTypeId { get; set; }

    public PaymentMethodTypeEnum PaymentMethodId { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public int PersonRegisterId { get; set; }

    public int PersonWorkerId { get; set; }

    public decimal Amount { get; set; }

    public DateTime PaymentDate { get; set; }

    public string OperationNumber { get; set; }

    public string ImageUrl { get; set; }

    public string Comments { get; set; }

    public int IncomeAndExpenseId { get; set; }

    public Person PersonRegister { get; set; }

    public Person PersonWorker { get; set; }

    public string Information { get; set; }

    public List<EgressInvoiceDto> Invoices { get; set; } = new List<EgressInvoiceDto>();

    public string EgressType => $"{this.EgressTypeId.GetEnumMemberValue()}";

    public string PettyCashType => $"{this.PettyCashTypeId.GetEnumMemberValue()}";

    public string PaymentMethod => $"{this.PaymentMethodId.GetEnumMemberValue()}";
}
