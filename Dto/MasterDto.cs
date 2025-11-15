namespace Exphadis.Core.Contract.Dto;

using Base;

public class MediaTypeDto : GenericDto
{
    public new string Extension { get; set; }
}

public class LevelDto : GenericDto
{
    public decimal PensionAmount { get; set; }
}

public class BankTypeDto : GenericDto
{
}

public class SectionDto : GenericDto
{
}

public class PeriodicityTypeDto : GenericDto
{
}

public class GradeDto : GenericDto
{
    public int IdLevel { get; set; }
}

public class PositionTypeDto : GenericDto
{
}

public class TurnDto : GenericDto
{
}

public class DepartmentDto : GenericDto
{
    public string Ubigeo { get; set; }
}

public class InformStageDto : GenericDto
{
    public int Order { get; set; }
}
