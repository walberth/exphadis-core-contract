namespace Exphadis.Core.Contract.Enums;

public enum CommitmentStatusEnum
{
    [EnumMember(Value = "PENDIENTE")]
    Pending = 1,

    [EnumMember(Value = "CUMPLIDO")]
    Complete = 2,

    [EnumMember(Value = "DESESTIMADO")]
    Dismissed = 3,
}
