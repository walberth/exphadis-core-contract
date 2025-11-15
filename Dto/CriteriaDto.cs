namespace Exphadis.Core.Contract.Dto;

using Base;

public class CriteriaDto : AuditDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public double Value { get; set; }

    public double Weight { get; set; }

    public int CompetenceId { get; set; }

    public int SubjectId { get; set; }

    public int IdWorker { get; set; }

    public int IdUnityConfiguration { get; set; }
}

public class CriteriaFilledDto
{
    public int IdArea { get; set; }

    public int IdCourse { get; set; }

    public int IdSubject { get; set; }

    public int IdWorker { get; set; }

    public int IdCompetence { get; set; }

    public int IdUnity { get; set; }

    public int IdCriteria { get; set; }

    public string NameCriteria { get; set; }

    public double WeightCriteria { get; set; }
}

public class AbilityGradeDto : GenericGradeDto
{
    public int CriteriaId { get; set; }

    public int CompetenceId { get; set; }

    public double Weight { get; set; }
}
