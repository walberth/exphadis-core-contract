// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Dto;

public class RequestMassiveProgressInform
{
    public int LevelId { get; set; }

    public int GradeId { get; set; }

    public int SectionId { get; set; }

    public int TurnId { get; set; }

    public int PeriodId { get; set; }

    public int Year { get; set; }

    public MediaTypeEnum MediaType { get; set; }

    public DateTime TimeStamp { get; set; }

    public string EmailTo { get; set; }

    public string EmailCc { get; set; }

    public string Subject { get; set; }
}
