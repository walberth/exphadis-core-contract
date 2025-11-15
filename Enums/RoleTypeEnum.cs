namespace Exphadis.Core.Contract.Enums;

public enum RoleTypeEnum
{
    [EnumMember(Value = "Administrador")]
    Administrator = 1,

    [EnumMember(Value = "Jefe")]
    Boss = 2,

    [EnumMember(Value = "Coordinador / Tutor")]
    Coordinator = 3,

    [EnumMember(Value = "Secretaria / Tesorera")]
    Secretary = 4,

    [EnumMember(Value = "Docente")]
    Teacher = 5,

    [EnumMember(Value = "Apoderado")]
    Attorney = 6,

    [EnumMember(Value = "Alumno")]
    Student = 7,

    [EnumMember(Value = "Analista")]
    Analyst = 8,

    [EnumMember(Value = "Practicante")]
    Practitioner = 9,

    [EnumMember(Value = "Informes")]
    Inform = 10,

    [EnumMember(Value = "Psicologa")]
    Psychologist = 11,
}
