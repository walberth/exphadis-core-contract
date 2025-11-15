namespace Exphadis.Core.Contract.Enums;
public enum ExceptionTypeEnum
{
    [EnumMember(Value = "")]
    Default = 1,

    [EnumMember(Value = "Qualification")]
    Qualification = 2,

    [EnumMember(Value = "DownloadFile")]
    DownloadFile = 3,
}
