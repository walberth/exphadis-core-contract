namespace Exphadis.Core.Contract.Dto;

public class PendingStudentSummaryDto
{
    public int StudentId { get; set; }

    public int EnrollmentId { get; set; }

    public string FullName { get; set; }

    public string GradeName { get; set; }

    public string LevelName { get; set; }
}