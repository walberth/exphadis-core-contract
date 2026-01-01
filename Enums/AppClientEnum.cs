namespace Exphadis.Core.Contract.Enums
{
    public enum AppClientEnum
    {
        [EnumMember(Value = "")]
        Default = 0,

        [EnumMember(Value = "81b07bc5-ccc8-4077-9afa-7c084efedaf2")]
        ExphadisApi = 1,

        [EnumMember(Value = "8bf0652b-620c-441b-94a1-9f4d9d83ffd9")]
        ExphadisIntranetWeb = 2,

        [EnumMember(Value = "6e34f63d-1551-46c4-ad43-41438edd348f")]
        ExphadisIntranetMobile = 3,

        [EnumMember(Value = "1c410284-3113-44e7-83eb-1c1d52443b10")]
        ExphadisWeb = 4,

        [EnumMember(Value = "06924f05-f14d-4d25-adab-87b0c9c3ca5a")]
        DevopsAutomation = 5,
    }
}
