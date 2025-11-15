namespace Exphadis.Core.Contract.Dto;

public class SupplierDto : AuditDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Code { get; set; }

    public PersonTypeEnum Type { get; set; }

    public EgressInvoiceTypeEnum ReceiptIssued { get; set; }

    public string Mobile { get; set; }

    public string Email { get; set; }

    public string Comments { get; set; }

    public string TypeValue => $"{this.Type.GetEnumMemberValue()}";

    public string ReceiptIssuedValue => $"{this.ReceiptIssued.GetEnumMemberValue()}";
}
