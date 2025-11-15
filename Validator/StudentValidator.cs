namespace Exphadis.Core.Contract.Validator;

public class StudentValidator : AbstractValidator<StudentDto>
{
    public StudentValidator() =>
        this.RuleSet("Create", () =>
        {
            this.When(x => x.Person != null, () =>
            {
                this.RuleFor(a => a.Person).SetValidator(new PersonValidator()!, "Create");
            });

            this.When(x => x.Person is { Direction: { } }, () =>
            {
                this.RuleFor(a => a.Person!.Direction).SetValidator(new DirectionValidator(), "Create");
            });
        });
}
