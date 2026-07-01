namespace Exphadis.Core.Contract.Validator;

using Exphadis.Core.Contract.Enums;

public class AnnouncementWhatsappPayloadValidator : AbstractValidator<AnnouncementWhatsappPayloadDto>
{
    public AnnouncementWhatsappPayloadValidator()
    {
        this.RuleFor(x => x.MessageType)
            .IsInEnum()
            .WithMessage("messageType debe ser uno de: 1 (TEXT), 2 (STICKER), 3 (TEXT_AND_STICKER), 4 (IMAGE), 5 (TEXT_AND_IMAGE)");

        this.RuleFor(x => x)
            .Must(HasRecipients)
            .WithMessage("Se requiere al menos un destinatario en recipientIds o recipientRefs");

        this.RuleFor(x => x.Text)
            .NotEmpty()
            .WithMessage("text es obligatorio para messageType 1, 3 o 5")
            .MaximumLength(4096)
            .WithMessage("text no debe exceder 4096 caracteres")
            .When(x => x.MessageType is WhatsappMessageTypeEnum.Text
                                     or WhatsappMessageTypeEnum.TextAndSticker
                                     or WhatsappMessageTypeEnum.TextAndImage);

        this.RuleFor(x => x.StickerId)
            .NotEmpty()
            .WithMessage("stickerId es obligatorio para messageType 2 o 3")
            .When(x => x.MessageType is WhatsappMessageTypeEnum.Sticker
                                     or WhatsappMessageTypeEnum.TextAndSticker);

        this.RuleFor(x => x.ImageUrl)
            .NotEmpty()
            .WithMessage("imageUrl es obligatoria para messageType 4 o 5")
            .Matches(@"^https?://.+")
            .WithMessage("imageUrl debe ser una URL http o https válida")
            .When(x => x.MessageType is WhatsappMessageTypeEnum.Image
                                     or WhatsappMessageTypeEnum.TextAndImage);

        this.RuleFor(x => x.ScheduledFrom)
            .NotEmpty()
            .WithMessage("scheduledFrom es obligatorio cuando se especifica scheduledTo")
            .When(x => x.ScheduledTo.HasValue && !x.ScheduledFrom.HasValue);

        this.RuleFor(x => x.ScheduledFrom)
            .Must(from => from!.Value > DateTime.UtcNow)
            .WithMessage("scheduledFrom debe ser una fecha/hora futura (en UTC)")
            .When(x => x.ScheduledFrom.HasValue);

        this.RuleFor(x => x.ScheduledTo)
            .GreaterThan(x => x.ScheduledFrom!.Value)
            .WithMessage("scheduledTo debe ser posterior a scheduledFrom")
            .When(x => x.ScheduledFrom.HasValue && x.ScheduledTo.HasValue);

        this.RuleFor(x => x)
            .Must(HaveMinimumSchedulingWindow)
            .WithMessage("La ventana entre scheduledFrom y scheduledTo debe ser de al menos 5 minutos")
            .When(x => x.ScheduledFrom.HasValue && x.ScheduledTo.HasValue);
    }

    private static bool HasRecipients(AnnouncementWhatsappPayloadDto payload) =>
        (payload.RecipientIds?.Any(id => !string.IsNullOrWhiteSpace(id)) ?? false)
        || (payload.RecipientRefs?.Any(id => !string.IsNullOrWhiteSpace(id)) ?? false);

    private static bool HaveMinimumSchedulingWindow(AnnouncementWhatsappPayloadDto payload) =>
        (payload.ScheduledTo!.Value - payload.ScheduledFrom!.Value) >= TimeSpan.FromMinutes(5);
}
