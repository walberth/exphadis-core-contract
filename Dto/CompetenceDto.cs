namespace Exphadis.Core.Contract.Dto;

using Base;

public class CompetenceDto : AuditDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int IdLevel { get; set; }

    public int IdArea { get; set; }

    public string Area { get; set; }

    public int Year { get; set; }

    public bool Transversal { get; set; }

    public IEnumerable<CriteriaDto> Capacities { get; set; } = new List<CriteriaDto>();

    public CognitiveQualificationDto CognitiveQualification { get; set; }

    public AptitudeQualificationDto AptitudeQualification { get; set; }

    public ProceduralQualificationDto ProceduralQualification { get; set; }

    public QualificationDto FinalQualification { get; set; }

    public List<QualificationDto> Notes { get; set; } = new();
}

public class CompetenceSelectedDto : AuditDto
{
    public int Id { get; set; }

    public int IdAsignature { get; set; }

    public int IdCompetence { get; set; }

    public int IdUnity { get; set; }

    public int IdWorker { get; set; }

    public int Year { get; set; }
}

public class CompetenceForSubjectDto
{
    public int Id { get; set; }

    public int IdCompetenceSelected { get; set; }

    public string Name { get; set; }

    public bool Transversal { get; set; }

    public int IdArea { get; set; }
}

public class CompetenceGradeDto : GenericGradeDto
{
    public int CompetenceId { get; set; }
}

public class UnityGradeDto : GenericGradeDto
{
    public double Average { get; set; }

    public double Score { get; set; }
}
