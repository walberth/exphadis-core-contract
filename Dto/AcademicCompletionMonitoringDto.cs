namespace Exphadis.Core.Contract.Dto;

using Exphadis.Core.Contract.Enums;

public sealed class AcademicCompletionFilterDto
{
    public int Year { get; set; }

    public int IdLevel { get; set; }

    public int IdGrade { get; set; }

    public int IdSection { get; set; }

    public int IdTurn { get; set; }

    public int IdUnity { get; set; }

    public int IdWorker { get; set; }

    public int Period { get; set; }

    public int Page { get; set; } = 1;

    public int PageSize { get; set; } = 50;

    public string Search { get; set; }

    public int StudentId { get; set; }

    public int EnrollmentId { get; set; }
}

public abstract class AcademicCompletionRowDto
{
    public int StudentId { get; set; }

    public int EnrollmentId { get; set; }

    public string StudentName { get; set; }

    public int Year { get; set; }

    public int? UnityId { get; set; }

    public AcademicCompletionStatusEnum Status { get; set; }

    public string StatusMessage { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

public sealed class CognitiveCompletionRowDto : AcademicCompletionRowDto
{
}

public sealed class AdditionalCompletionRowDto : AcademicCompletionRowDto
{
}

public sealed class ProceduralCompletionRowDto : AcademicCompletionRowDto
{
}

public sealed class AptitudinalCompletionRowDto : AcademicCompletionRowDto
{
}

public sealed class ConductCompletionRowDto : AcademicCompletionRowDto
{
}

public sealed class RecommendationCompletionRowDto : AcademicCompletionRowDto
{
}

public sealed class AcademicCompletionSummaryRowDto
{
    public int StudentId { get; set; }

    public int EnrollmentId { get; set; }

    public string StudentName { get; set; }

    public AcademicCompletionStatusEnum CognitiveStatus { get; set; }

    public string CognitiveStatusMessage { get; set; }

    public AcademicCompletionStatusEnum AdditionalStatus { get; set; }

    public string AdditionalStatusMessage { get; set; }

    public AcademicCompletionStatusEnum ProceduralStatus { get; set; }

    public string ProceduralStatusMessage { get; set; }

    public AcademicCompletionStatusEnum AptitudinalStatus { get; set; }

    public string AptitudinalStatusMessage { get; set; }

    public AcademicCompletionStatusEnum ConductStatus { get; set; }

    public string ConductStatusMessage { get; set; }

    public AcademicCompletionStatusEnum RecommendationStatus { get; set; }

    public string RecommendationStatusMessage { get; set; }

    public AcademicCompletionStatusEnum OverallStatus { get; set; }

    public string OverallStatusMessage { get; set; }

    public bool IsFullyCompleted { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

public sealed class AcademicCompletionDetailDto
{
    public int StudentId { get; set; }

    public int EnrollmentId { get; set; }

    public string StudentName { get; set; }

    public int Year { get; set; }

    public int? UnityId { get; set; }

    public string UnityName { get; set; }

    public AcademicCompletionStatusEnum OverallStatus { get; set; }

    public string OverallMessage { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public List<AcademicCompletionDetailItemDto> Items { get; set; } = new();
}

public sealed class AcademicCompletionDetailItemDto
{
    public int? SubjectId { get; set; }

    public string SubjectName { get; set; }

    public int? WorkerId { get; set; }

    public string WorkerName { get; set; }

    public int? TeacherId { get; set; }

    public string TeacherName { get; set; }

    public string ItemName { get; set; }

    public int? UnityId { get; set; }

    public string UnityName { get; set; }

    public AcademicCompletionStatusEnum Status { get; set; }

    public string StatusMessage { get; set; }

    public string TooltipMessage { get; set; }

    public List<string> MissingReasons { get; set; } = new();

    public int? RecordedCount { get; set; }

    public int? ExpectedCount { get; set; }

    public List<AcademicCompletionCompetenceDetailDto> Competences { get; set; } = new();
}

public sealed class AcademicCompletionCompetenceDetailDto
{
    public int CompetenceId { get; set; }

    public string CompetenceName { get; set; }

    public AcademicCompletionStatusEnum Status { get; set; }

    public string StatusMessage { get; set; }

    public List<AcademicCompletionCriteriaDetailDto> Criteria { get; set; } = new();
}

public sealed class AcademicCompletionCriteriaDetailDto
{
    public int CriteriaId { get; set; }

    public string CriteriaName { get; set; }

    public double? Weight { get; set; }

    public double? Score { get; set; }

    public AcademicCompletionStatusEnum Status { get; set; }

    public string StatusMessage { get; set; }
}