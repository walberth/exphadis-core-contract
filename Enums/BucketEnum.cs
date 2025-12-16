// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Enums;

public enum BucketEnum
{
    [EnumMember(Value = "exphadis-attach-file")]
    AttachFile = 0,

    [EnumMember(Value = "wg-database-backup")]
    DatabaseBackup = 1,

    [EnumMember(Value = "exphadis-worker-tickets")]
    WorkerTickets = 2,

    [EnumMember(Value = "exphadis-student-tickets")]
    StudentTickets = 3,

    [EnumMember(Value = "exphadis-report-files")]
    ReportFiles = 4,

    [EnumMember(Value = "wg-html-templates")]
    HtmlTemplates = 5,

    [EnumMember(Value = "exphadis-old-inform-progress")]
    OldInformProgress = 6,
}
