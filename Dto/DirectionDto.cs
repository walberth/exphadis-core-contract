namespace Exphadis.Core.Contract.Dto;

using Base;

public class DirectionDto : AuditDto
{
    public int Id { get; set; }

    public int IdPerson { get; set; }

    public string Direction { get; set; } = string.Empty;

    public int IdDistrict { get; set; }

    public int IdProvince { get; set; }

    public int IdDepartment { get; set; }
}
