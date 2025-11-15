namespace Exphadis.Core.Contract.Validator;

public class WorkerValidator : AbstractValidator<WorkerDto>
{
    public WorkerValidator()
    {
        this.RuleFor(x => x.Person.FirstName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el nombre");

        this.RuleFor(x => x.Person.FatherLastName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el apellido paterno");

        this.RuleFor(x => x.Person.MotherLastName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el apellido materno");

        this.RuleFor(x => x.Person.BirthDate)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .NotEqual(DateTime.Today)
            .WithMessage("No se han ingresado la fecha de nacimiento del apoderado o esta no es correcta");

        this.RuleFor(x => x.Person.Email)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el número de correo");

        this.RuleFor(x => x.AssistanceId)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el identificador para el marcador de asistencia");

        this.RuleFor(x => x.Person.DocumentType)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el tipo de documento");

        this.RuleFor(x => x.Person.Document)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el número de documento");

        this.RuleFor(x => x.Person.Mobile)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el número de celular");

        this.RuleFor(x => x.IdGradeInstructionType)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han ingresado el grado de instrucción");

        this.RuleFor(x => x.Person.Direction.IdDepartment)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han indicado el departamento donde vive");

        this.RuleFor(x => x.Person.Direction.IdProvince)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han indicado la provincia donde vive");

        this.RuleFor(x => x.Person.Direction.IdDistrict)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han indicado el distrito donde vive");

        this.RuleFor(x => x.Person.Direction.Direction)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .NotEmpty()
            .WithMessage("No se han indicado el dirección donde vive");
    }
}
