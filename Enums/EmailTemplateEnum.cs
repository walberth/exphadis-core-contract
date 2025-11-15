// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Enums;

public enum EmailTemplateEnum
{
    [EnumMember(Value = "exphadis-inform-request.html")]
    InformRequest = 1,

    [EnumMember(Value = "exphadis-inform-enrollment.html")]
    EnrollmentInform = 2,

    [EnumMember(Value = "exphadis-position-postulation.html")]
    PositionPostulation = 3,

    [EnumMember(Value = "exphadis-position-rejected.html")]
    PositionPostulationRejected = 4,

    [EnumMember(Value = "exphadis-report-in-email.html")]
    ReportToEmail = 5,
}
