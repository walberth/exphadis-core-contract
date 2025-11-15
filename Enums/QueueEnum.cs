// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Enums;

public enum QueueEnum
{
    [EnumMember(Value = "")]
    Default = 0,

    [EnumMember(Value = "https://sqs.us-east-1.amazonaws.com/062610911578/QueueExphadisInformProgress")]
    InformProgress = 1,
}
