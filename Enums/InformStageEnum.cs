namespace Exphadis.Core.Contract.Enums;

public enum InformStageEnum
{
    [EnumMember(Value = "INICIADO")]
    Started = 1,

    [EnumMember(Value = "INFORMADO")]
    Inform,

    [EnumMember(Value = "SEGUIMIENTO")]
    Followed,

    [EnumMember(Value = "OBTENIDO")]
    Obtained,

    [EnumMember(Value = "RECHAZADO")]
    Rejected,

    [EnumMember(Value = "PERDIDO")]
    Lost,
}
