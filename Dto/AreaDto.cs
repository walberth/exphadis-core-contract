// <copyright file="AreaDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Exphadis.Core.Contract.Dto;

public class AreaDto : AuditDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int IdLevel { get; set; }

    public int Year { get; set; }

    public bool Exonerated { get; set; }

    public List<CompetenceDto> Competences { get; set; } = new();

    public IEnumerable<CourseDto> Courses { get; set; } = new HashSet<CourseDto>();

    public List<QualificationDto> LastNotesByPeriod { get; set; } = new();

    public string FinalNote => this.ObtainFinalNote();

    private string ObtainFinalNote()
    {
        var value = string.Empty;
        if (this.LastNotesByPeriod.Count == 0)
        {
            return value;
        }

        var noteOfLastPeriod = this.LastNotesByPeriod.ElementAtOrDefault(3);

        if (noteOfLastPeriod != null)
        {
            value = noteOfLastPeriod.Value;
        }

        return value;
    }

    public List<CompetenceDto> FirstCompetence =>
        this.Competences != null && this.Competences.Count != 0
            ? this.Competences.Take(1).ToList()
            : new List<CompetenceDto>();

    public List<CompetenceDto> OtherCompetences =>
        this.Competences != null && this.Competences.Count != 0 && this.Competences.Count > 1
            ? this.Competences.Skip(1).ToList()
            : new List<CompetenceDto>();

    public int CompetenceCount => this.Competences.Count + 1;
}

public class AreaNoteDto : QualificationDto
{
    public int AreaId { get; set; }

    public int EnrollmentId { get; set; }
}
