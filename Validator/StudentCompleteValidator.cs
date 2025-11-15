namespace Exphadis.Core.Contract.Validator;

public class StudentCompleteValidator : AbstractValidator<StudentRegisterDto>
{
    public StudentCompleteValidator()
    {
        // Student
        this.RuleFor(x => x.Student.Person.FirstName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el nombre del estudiante");
        this.RuleFor(x => x.Student.Person.FatherLastName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el apellido paterno del estudiante");
        this.RuleFor(x => x.Student.Person.MotherLastName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el apellido materno del estudiante");
        this.RuleFor(x => x.Student.Person.BirthDate)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .NotEqual(DateTime.Today)
            .WithMessage("No se han ingresado la fecha de nacimiento del estudiante o esta no es correcta");
        this.RuleFor(x => x.Student.Person.Document)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el número de documento del apoderado");
        this.RuleFor(x => x.Student.Person.Direction.IdDepartment)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el departamento del estudiante");
        this.RuleFor(x => x.Student.Person.Direction.IdProvince)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado la provincia del estudiante");
        this.RuleFor(x => x.Student.Person.Direction.IdDistrict)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el distrito del estudiante");
        this.RuleFor(x => x.Student.Person.Direction.Direction)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado la dirección del estudiante");

        // Atorney
        this.RuleFor(x => x.Student.Attorney.Person.FirstName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el nombre del apoderado");
        this.RuleFor(x => x.Student.Attorney.Person.FatherLastName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el apellido paterno del apoderado");
        this.RuleFor(x => x.Student.Attorney.Person.MotherLastName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el apellido materno del apoderado");
        this.RuleFor(x => x.Student.Attorney.Person.BirthDate)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .NotEqual(DateTime.Today)
            .WithMessage("No se han ingresado la fecha de nacimiento del apoderado o esta no es correcta");
        this.RuleFor(x => x.Student.Attorney.Person.Document)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el número de documento del apoderado");
        this.RuleFor(x => x.Student.Attorney.Person.Direction.IdDepartment)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el departamento del apoderado");
        this.RuleFor(x => x.Student.Attorney.Person.Direction.IdProvince)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado la provincia del apoderado");
        this.RuleFor(x => x.Student.Attorney.Person.Direction.IdDistrict)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el distrito del apoderado");
        this.RuleFor(x => x.Student.Attorney.Person.Direction.Direction)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado la dirección del apoderado");
        this.RuleFor(x => x.Student.Attorney.IdRelationshipType)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el tipo de relación del apoderado con el estudiante");
    }
}
