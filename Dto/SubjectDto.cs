namespace Exphadis.Core.Contract.Dto;

using Base;

public class SubjectDto : AuditDto
{
    public int Id { get; set; }

    public int IdCourse { get; set; }

    public string CourseName { get; set; }

    public int IdWorker { get; set; }

    public string WorkerName { get; set; }

    public int IdLevel { get; set; }

    public string Level { get; set; }

    public int IdGrade { get; set; }

    public string Grade { get; set; }

    public int IdSection { get; set; }

    public string Section { get; set; }

    public int IdTurn { get; set; }

    public string Turn { get; set; }

    public int Year { get; set; }

    public IEnumerable<AsignatureStudentDto> SubjectStudents { get; set; } = new HashSet<AsignatureStudentDto>();
}

public class UpdateAdditionalQualificationDto
{
    public int IdGrade { get; set; }

    public int IdOldWorker { get; set; }

    public int IdNewWorker { get; set; }

    public int Year { get; set; }

    public string UserUpdated { get; set; }

    public DateTime? TimeUpdated { get; set; }
}

public class SubjectByUnityDto
{
    public int Id { get; set; }

    public int IdCourse { get; set; }

    public string CourseName { get; set; }

    public int IdLevel { get; set; }

    public string Level { get; set; }

    public int IdGrade { get; set; }

    public string Grade { get; set; }

    public int IdSection { get; set; }

    public string Section { get; set; }

    public int IdTurn { get; set; }

    public string Turn { get; set; }

    public int IdUnity { get; set; }

    public string Unity { get; set; }

    public int Year { get; set; }

    public int CompetencesCount { get; set; }
}
