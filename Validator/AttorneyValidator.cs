namespace Exphadis.Core.Contract.Validator;

public class AttorneyValidator : AbstractValidator<AttorneyDto>
{
    public AttorneyValidator()
    {
        // Atorney
        this.RuleFor(x => x.Person.FirstName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el nombre del apoderado");
        this.RuleFor(x => x.Person.FatherLastName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el apellido paterno del apoderado");
        this.RuleFor(x => x.Person.MotherLastName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el apellido materno del apoderado");
        this.RuleFor(x => x.Person.BirthDate)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .NotEqual(DateTime.Today)
            .WithMessage("No se han ingresado la fecha de nacimiento del apoderado o esta no es correcta");
        this.RuleFor(x => x.Person.Document)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el número de documento del apoderado");
        this.RuleFor(x => x.Person.Direction.IdDepartment)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el departamento del apoderado");
        this.RuleFor(x => x.Person.Direction.IdProvince)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado la provincia del apoderado");
        this.RuleFor(x => x.Person.Direction.IdDistrict)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el distrito del apoderado");
        this.RuleFor(x => x.Person.Direction.Direction)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado la dirección del apoderado");
        this.RuleFor(x => x.IdRelationshipType)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el tipo de relación del apoderado con el estudiante");
    }
}
