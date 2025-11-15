namespace Exphadis.Core.Contract.Dto;

using Base;

public class TutorshipDto : AuditDto
{
    public int Id { get; set; }

    public int IdWorker { get; set; }

    public int IdLevel { get; set; }

    public int IdGrade { get; set; }

    public int IdSection { get; set; }

    public int Year { get; set; }
}

public class TutorshipMessageDto : AuditDto
{
    public int Id { get; set; }

    public int IdStudent { get; set; }

    public int IdTutorship { get; set; }

    public int IdEnrollment { get; set; }

    public TutorshipMessageEnum Type { get; set; }

    public string Message { get; set; }

    public int Year { get; set; }

    public string CompleteName { get; set; } // TODO: REVIEW THIS

    public DateTime TimeLastRecommendation { get; set; } // TODO: REVIEW THIS

    public string LastRecommendation { get; set; } // TODO: REVIEW THIS

    public int BimesterBelong { get; set; } // TODO: REVIEW THIS
}
