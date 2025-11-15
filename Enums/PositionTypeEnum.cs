namespace Exphadis.Core.Contract.Enums;

public enum PositionTypeEnum
{
    [EnumMember(Value = "")]
    Default = 0,

    [EnumMember(Value = "Docente")]
    Teacher = 1,

    [EnumMember(Value = "Personal Administrativo")]
    AdministrativePersonal = 2,

    [EnumMember(Value = "Limpieza")]
    Cleaning = 3,

    [EnumMember(Value = "Tutor")]
    Tutor = 4,

    [EnumMember(Value = "Secretaria")]
    Secretary = 5,

    [EnumMember(Value = "Informes")]
    Inform = 6,

    [EnumMember(Value = "Psicóloga")]
    Psychologist = 7,

    [EnumMember(Value = "Directora")]
    Director = 8,

    [EnumMember(Value = "Supervisora")]
    Supervisor = 9,

    [EnumMember(Value = "Coordinadora")]
    Coordinator = 10,

    [EnumMember(Value = "Auxiliar")]
    Assistant = 11,
}
