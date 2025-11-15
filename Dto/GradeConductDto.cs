namespace Exphadis.Core.Contract.Dto;

using Base;

public class StudentConductQualificationDto
{
    public int StudentId { get; set; }

    public string StudentName { get; set; }

    public int EnrollmentId { get; set; }

    public int Year { get; set; }

    public List<QualificationDto> Notes { get; set; } = new();

    public GenericGradeDto Qualification { get; set; }

    public string FinalNote => this.ObtainFinalNote();

    private string ObtainFinalNote()
    {
        var value = string.Empty;
        if (this.Notes.Count == 0)
        {
            return value;
        }

        var noteOfLastPeriod = this.Notes.ElementAtOrDefault(3);

        if (noteOfLastPeriod is not null)
        {
            value = noteOfLastPeriod.Value;
        }

        return value;
    }
}

public class GenericGradeDto : AuditDto
{
    public int Id { get; set; }

    public double Value { get; set; }

    public int StudentId { get; set; }

    public int EnrollmentId { get; set; }

    public int GradeId { get; set; }

    public int WorkerId { get; set; }

    public int UnityId { get; set; }

    public int Period { get; set; }

    public int SubjectId { get; set; }

    public int Year { get; set; }
}
