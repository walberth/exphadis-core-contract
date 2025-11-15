namespace Exphadis.Core.Contract.Dto;

public class CognitiveQualificationDto : QualificationDto
{
    public int IdCompetence { get; set; }
}

public class CognitiveGradeDto
{
    public IEnumerable<UnityGradeDto> UnityGrades { get; set; } = new HashSet<UnityGradeDto>();

    public IEnumerable<AbilityGradeDto> AbilityGrades { get; set; } = new HashSet<AbilityGradeDto>();

    public IEnumerable<CompetenceGradeDto> CompetenceGrades { get; set; } = new HashSet<CompetenceGradeDto>();
}

public class AdditionalGradeDto
{
    public IEnumerable<GenericGradeDto> ProceduralGrades { get; set; }

    public IEnumerable<GenericGradeDto> AptitudeGrades { get; set; }
}
