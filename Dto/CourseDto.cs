namespace Exphadis.Core.Contract.Dto;

using Base;

public class CourseDto : AuditDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int IdLevel { get; set; }

    public int IdArea { get; set; }

    public string AreaName { get; set; }

    public string Level { get; set; }

    public int Year { get; set; }
}
