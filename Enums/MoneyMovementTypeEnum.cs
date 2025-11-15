namespace Exphadis.Core.Contract.Enums;

public enum MoneyMovementTypeEnum
{
    [EnumMember(Value = "DEFAULT")]
    Default = 0,

    [EnumMember(Value = "PENSIONES")]
    Pensions = 1,

    [EnumMember(Value = "SUELDOS")]
    Payments = 2,

    [EnumMember(Value = "MORAS")]
    Arrears = 3,

    [EnumMember(Value = "MATERIAL EDUCATIVO")]
    EducativeMaterial = 4,

    [EnumMember(Value = "UNIFORMES")]
    Uniforms = 5,

    [EnumMember(Value = "MATRICULAS")]
    Enrollments = 6,

    [EnumMember(Value = "DESCUENTOS POR TARDANZA")]
    DelayDiscounts = 7,

    [EnumMember(Value = "DESCUENTOS POR FALTA")]
    FaultsDiscounts = 8,

    [EnumMember(Value = "ADELANTO DE SUELDOS")]
    PaymentAdvance = 9,

    [EnumMember(Value = "OTROS INGRESOS")]
    OtherIncomes = 10,

    [EnumMember(Value = "OTROS EGRESOS")]
    OtherEgress = 11,

    [EnumMember(Value = "CAJA CHICA")]
    PettyCash = 12,
}
