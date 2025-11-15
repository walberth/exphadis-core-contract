namespace Exphadis.Core.Contract.Dto;

using Enums;

public class IncomeAndExpensesDto
{
    public int Id { get; set; }

    public string Detail { get; set; }

    public string Month { get; set; }

    public decimal Amount { get; set; }

    public int Year { get; set; }

    public int IdPerson { get; set; }

    public int IdPaymentMethod { get; set; }

    public MoneyMovementTypeEnum IncomeMoneyMovementTypeEnum { get; set; }

    public string UserRegister { get; set; }

    public string UserUpdated { get; set; }

    public int IdReturn { get; set; }

    public DateTime? TimeRegister { get; set; }

    public DateTime? TimeUpdated { get; set; }

    public PersonDto Person { get; set; }

    public PaymentTypeDto PaymentType { get; set; }

    public MoneyMovementTypeDto MoneyMovementType { get; set; }
}
