namespace Exphadis.Core.Contract.Validator;

public class BankPaymentValidator : AbstractValidator<StudentBankPaymentDto>
{
    public BankPaymentValidator()
    {
        this.RuleFor(x => x.BankPayment)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se ha está enviando información del pago del banco");

        this.RuleFor(x => x.StudentPayment)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se ha está enviando información del pago del estudiante");

        this.RuleFor(x => x.IncomeAndExpenses)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se ha está enviando información de cuadre");

        this.RuleFor(x => x.StudentPayment.IncomeMoneyMovementTypeEnum)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se ha indicado el tipo de movimiento que se a realizado");

        this.RuleFor(x => x.StudentPayment.IdStudent)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se ha indicado a que estudiante pertenece el pago");

        this.RuleFor(x => x.StudentPayment.IdAttorney)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se ha indicado a el apoderado al que pertenece el pago");

        this.RuleFor(x => x.StudentPayment.Amount)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se ha indicado el monto de pago");

        this.RuleFor(x => x.StudentPayment.IdPaymentMethod)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se ha indicado el método de pago");

        this.RuleFor(x => x.StudentPayment.IdPerson)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se ha indicado el identificador de la persona");
    }
}
