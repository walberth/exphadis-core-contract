namespace Exphadis.Core.Contract.Enums;

public enum NotificationPriorityEnum
{
    [EnumMember(Value = "BAJA")]
    Low = 1,

    [EnumMember(Value = "MEDIA")]
    Medium = 2,

    [EnumMember(Value = "ALTA")]
    High = 3,

    [EnumMember(Value = "CRITICA")]
    Critical = 4,
}

public enum NotificationMessageTypeEnum
{
    [EnumMember(Value = "")]
    Default = 0,

    [EnumMember(Value = "Text")]
    Text = 1,

    [EnumMember(Value = "HTML")]
    Html = 2,
}
