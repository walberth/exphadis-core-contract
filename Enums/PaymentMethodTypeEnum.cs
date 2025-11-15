namespace Exphadis.Core.Contract.Enums;

[Flags]
public enum PaymentMethodTypeEnum
{
    [EnumMember(Value = "OFICINA")]
    Office = 2,

    [EnumMember(Value = "BANCO")]
    Bank = 4,
}
