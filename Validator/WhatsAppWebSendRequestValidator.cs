namespace Exphadis.Core.Contract.Validator;

public class WhatsAppWebSendRequestValidator : AbstractValidator<WhatsAppWebSendRequestDto>
{
    private static readonly string[] AllowedTypes = { "text", "image", "document" };

    public WhatsAppWebSendRequestValidator()
    {
        this.RuleFor(x => x.To)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("El número de destino es obligatorio")
            .Matches(@"^\d{10,15}$")
            .WithMessage("El número de destino debe tener entre 10 y 15 dígitos");

        this.RuleFor(x => x.Type)
            .NotEmpty()
            .WithMessage("El tipo de mensaje es obligatorio")
            .Must(t => AllowedTypes.Contains(t, StringComparer.OrdinalIgnoreCase))
            .WithMessage("El tipo debe ser: text, image o document");

        this.RuleFor(x => x.Text)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("El texto del mensaje es obligatorio")
            .MaximumLength(4096)
            .WithMessage("El texto no debe exceder 4096 caracteres")
            .When(x => string.Equals(x.Type, "text", StringComparison.OrdinalIgnoreCase));

        this.RuleFor(x => x.ImageUrl)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("La URL es obligatoria para mensajes de tipo image/document")
            .Matches(@"^https?://.+")
            .WithMessage("La URL debe ser válida (http o https)")
            .When(x => string.Equals(x.Type, "image", StringComparison.OrdinalIgnoreCase)
                     || string.Equals(x.Type, "document", StringComparison.OrdinalIgnoreCase));

        this.RuleFor(x => x.Caption)
            .MaximumLength(1024)
            .WithMessage("El caption no debe exceder 1024 caracteres")
            .When(x => !string.IsNullOrWhiteSpace(x.Caption));

        this.RuleFor(x => x.Filename)
            .NotEmpty()
            .WithMessage("El nombre de archivo es obligatorio para documentos")
            .MaximumLength(256)
            .WithMessage("El nombre de archivo no debe exceder 256 caracteres")
            .When(x => string.Equals(x.Type, "document", StringComparison.OrdinalIgnoreCase));
    }
}
