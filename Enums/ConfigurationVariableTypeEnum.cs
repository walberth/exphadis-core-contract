namespace Exphadis.Core.Contract.Enums;

public enum ConfigurationVariableTypeEnum
{
    [EnumMember(Value = "MAINTENANCE")]
    Maintenance = 1,

    [EnumMember(Value = "CLEAN_LOCAL_STORAGE")]
    CleanLocalStorage,

    [EnumMember(Value = "TEST")]
    Test,

    [EnumMember(Value = "ADMISSION_TIME")]
    AdmissionTime,

    [EnumMember(Value = "WEB_ENROLLMENT_ENABLED")]
    WebEnrollmentEnabled,
}
