namespace Exphadis.Core.Contract.Dto;

public class EgressInvoiceDto : AuditDto
{
    public int Id { get; set; }

    public EgressInvoiceTypeEnum TypeId { get; set; }

    public int SupplierId { get; set; }

    public decimal Amount { get; set; }

    public DateTime Date { get; set; }

    public string Code { get; set; }

    public int PersonRegisterId { get; set; }

    public IEnumerable<int> EgressIds { get; set; }

    public string EgressInformation { get; set; }

    public string AttachmentUrl { get; set; }

    public string Comments { get; set; }

    public string Type => $"{this.TypeId.GetEnumMemberValue()}";

    public SupplierDto Supplier { get; set; }
}
