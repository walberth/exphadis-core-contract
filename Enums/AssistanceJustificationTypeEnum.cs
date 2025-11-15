namespace Exphadis.Core.Contract.Enums;

public enum AssistanceJustificationTypeEnum
{
    [EnumMember(Value = "Sin Falta")]
    NoAbsence = 1,

    [EnumMember(Value = "Sin Tardanza")]
    NoDelay = 2,

    [EnumMember(Value = "Menos Minutos de Tardanza")]
    LessDelayMinutes = 3,
}
