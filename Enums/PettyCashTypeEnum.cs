namespace Exphadis.Core.Contract.Enums;

public enum PettyCashTypeEnum
{
    [EnumMember(Value = "")]
    Default = 0,

    [EnumMember(Value = "LIMPIEZA")]
    Cleaning = 1,

    [EnumMember(Value = "UTILES")]
    OfficeSupplies = 2,

    [EnumMember(Value = "SERVICIOS")]
    Services = 3,

    [EnumMember(Value = "OTROS")]
    Others = 4,
}
