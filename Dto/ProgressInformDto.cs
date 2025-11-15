// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Dto;

public class ProgressInformDto
{
    public string Year { get; set; }

    public string TimeStamp { get; set; }

    public string LevelName { get; set; }

    public string GradeName { get; set; }

    public string SectionName { get; set; }

    public string StudentName { get; set; }

    public string StudentDocument { get; set; }

    public List<AreaDto> Areas { get; set; }

    public StudentConductQualificationDto StudentConductQualification { get; set; }

    public List<GradeEquivalenceConfigDto> GradeEquivalences { get; set; }

    public List<RecommendationDto> Recommendations { get; set; }

    public string ModularCode => !string.IsNullOrEmpty(this.LevelName)
        ? this.LevelName.Equals("Inicial")
            ? "1570811"
            : this.LevelName.Equals("Primaria")
                ? "0825588"
                : this.LevelName.Equals("Secundaria")
                    ? "0872689"
                    : string.Empty
        : string.Empty;
}
