namespace Exphadis.Core.Contract.Dto;

public class WorkerAssignmentDto
{
    public IEnumerable<GradeDto> Grades { get; set; } = new HashSet<GradeDto>();

    public IEnumerable<LevelDto> Levels { get; set; } = new HashSet<LevelDto>();

    public IEnumerable<SectionDto> Sections { get; set; } = new HashSet<SectionDto>();

    public IEnumerable<TurnDto> Turns { get; set; } = new HashSet<TurnDto>();
}
