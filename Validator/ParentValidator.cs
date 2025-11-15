namespace Exphadis.Core.Contract.Validator;

public class ParentValidator : AbstractValidator<ParentDto>
{
    public ParentValidator()
    {
        this.RuleFor(x => x.Person.FirstName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el nombre del estudiante");
        this.RuleFor(x => x.Person.FatherLastName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el apellido paterno del estudiante");
        this.RuleFor(x => x.Person.MotherLastName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el apellido materno del estudiante");
        this.RuleFor(x => x.Person.BirthDate)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .NotEqual(DateTime.Today)
            .WithMessage("No se han ingresado la fecha de nacimiento del estudiante o esta no es correcta");
        this.RuleFor(x => x.Person.Document)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el número de documento del apoderado");
        this.RuleFor(x => x.IdRelationshipType)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se ha indicado el tipo de relación del apoderado");
    }
}
