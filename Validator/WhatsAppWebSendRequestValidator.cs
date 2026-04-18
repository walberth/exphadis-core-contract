namespace Exphadis.Core.Contract.Validator;

public class WhatsAppWebSendRequestValidator : AbstractValidator<WhatsAppWebSendRequestDto>
{
    public WhatsAppWebSendRequestValidator()
    {
        this.RuleFor(x => x.To)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("El número de destino es obligatorio")
            .Matches(@"^\d{10,15}$")
            .WithMessage("El número de destino debe tener entre 10 y 15 dígitos");

        this.RuleFor(x => x.Text)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("El texto del mensaje es obligatorio")
            .MaximumLength(4096)
            .WithMessage("El texto no debe exceder 4096 caracteres");

        this.RuleFor(x => x.Type)
            .NotEmpty()
            .WithMessage("El tipo de mensaje es obligatorio");
    }
}
