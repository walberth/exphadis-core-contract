namespace Exphadis.Core.Contract.Dto;

using Enums;

public class EnrollmentPaymentDto
{
    public EnrollmentDto Enrollment { get; set; }

    public decimal TotalPaymentAmount =>
        this.IncomeMoneyMovementTypeEnum == MoneyMovementTypeEnum.Pensions
            ? this.Enrollment.PensionAmountByStudent
            : 0;

    public decimal PaidBalance { get; set; }

    public decimal OutstandingBalance { get; set; }

    public decimal ArrearAmount { get; set; }

    public StatusEnum Status { get; set; }

    public MoneyMovementTypeEnum IncomeMoneyMovementTypeEnum { get; set; }

    public MonthEnum MonthEnum { get; set; }
}
