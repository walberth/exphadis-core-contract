namespace Exphadis.Core.Contract.Validator;

public class PersonValidator : AbstractValidator<PersonDto>
{
    public PersonValidator() =>
        this.RuleSet("Create", () =>
        {
            this.RuleFor(x => x.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .NotEmpty()
                .WithMessage("No se han ingresado el nombre del estudiante");
            this.RuleFor(x => x.FatherLastName)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .NotEmpty()
                .WithMessage("No se han ingresado el apellido paterno del estudiante");
            this.RuleFor(x => x.MotherLastName)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .NotEmpty()
                .WithMessage("No se han ingresado el apellido materno del estudiante");
            this.RuleFor(x => x.BirthDate)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .NotEmpty()
                .NotEqual(DateTime.Today)
                .WithMessage("No se han ingresado la fecha de nacimiento del estudiante o esta no es correcta");
            this.RuleFor(x => x.Document)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .NotEmpty()
                .WithMessage("No se han ingresado el número de documento del apoderado");
        });
}
