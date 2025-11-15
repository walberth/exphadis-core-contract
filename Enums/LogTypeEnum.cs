namespace Exphadis.Core.Contract.Enums;

public enum LogTypeEnum
{
    [EnumMember(Value = "Verbose")]
    VERBOSE = 0,

    [EnumMember(Value = "Debug")]
    DEBUG = 1,

    [EnumMember(Value = "Information")]
    INFORMATION = 2,

    [EnumMember(Value = "Warning")]
    WARNING = 3,

    [EnumMember(Value = "Error")]
    ERROR = 4,

    [EnumMember(Value = "Fatal")]
    FATAL = 5,
}
