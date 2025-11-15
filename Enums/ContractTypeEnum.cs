namespace Exphadis.Core.Contract.Enums;

public enum ContractTypeEnum
{
    [EnumMember(Value = "GENERAL")]
    PayRoll = 1,

    [EnumMember(Value = "RH")]
    Receipt = 2,

    [EnumMember(Value = "REMYPE")]
    Remype = 3,

    [EnumMember(Value = "MYPE")]
    Mype = 4,
}
