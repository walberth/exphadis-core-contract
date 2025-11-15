namespace Exphadis.Core.Contract.Dto;

using Enums;

public class MoneyMovementTypeDto
{
    public int Id { get; set; }

    public string Name { get; set; }
}

public class MoneyMovementReportDto
{
    public string UrlValidate { get; set; }

    public string UrlInvoice { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string OperationNumber { get; set; }

    public decimal Amount { get; set; }

    public decimal? AmountShouldPay { get; set; }

    public string StudentCompleteName { get; set; }

    public string AttorneyCompleteName { get; set; }

    public string Document { get; set; }

    public string PaymentMethod { get; set; }

    public MoneyMovementTypeEnum IncomeMoneyMovementTypeEnum { get; set; }

    public string PaymentType { get; set; }

    public string Level { get; set; }

    public string Grade { get; set; }

    public string Month { get; set; }

    public string Year { get; set; }

    public string PersonRegister { get; set; }

    public bool Validated { get; set; }

    public bool HaveInvoice { get; set; }

    public string BankType { get; set; }

    public int IdStudent { get; set; }

    public int IdEnrollment { get; set; }

    public string Comment { get; set; }

    public decimal Arrear { get; set; }

    public string Invoice { get; set; }
}
