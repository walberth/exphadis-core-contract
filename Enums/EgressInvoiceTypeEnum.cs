namespace Exphadis.Core.Contract.Enums;

public enum EgressInvoiceTypeEnum
{
    [EnumMember(Value = "")]
    Default = 0,

    [EnumMember(Value = "FACTURA")]
    Bill = 1,

    [EnumMember(Value = "BOLETA")]
    Ticket = 2,

    [EnumMember(Value = "RH")]
    RH = 3,
}
