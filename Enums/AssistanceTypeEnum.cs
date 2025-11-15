namespace Exphadis.Core.Contract.Enums;

public enum AssistanceTypeEnum
{
    [EnumMember(Value = "Normal")]
    Normal = 1,

    [EnumMember(Value = "Tardanza")]
    Delay,

    [EnumMember(Value = "Falta")]
    Absence,
}
