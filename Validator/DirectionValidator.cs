namespace Exphadis.Core.Contract.Validator;

public class DirectionValidator : AbstractValidator<DirectionDto>
{
    public DirectionValidator() =>
        this.RuleSet("Create", () =>
        {
            this.RuleFor(x => x.IdDepartment)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .NotEmpty()
                .WithMessage("No se han ingresado el departamento");
            this.RuleFor(x => x.IdProvince)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .NotEmpty()
                .WithMessage("No se han ingresado la provincia");
            this.RuleFor(x => x.IdDistrict)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .NotEmpty()
                .WithMessage("No se han ingresado el distrito");
            this.RuleFor(x => x.Direction)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .NotEmpty()
                .WithMessage("No se han ingresado la dirección");
        });
}
