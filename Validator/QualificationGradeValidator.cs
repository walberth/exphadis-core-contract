namespace Exphadis.Core.Contract.Validator;

/// <summary>
/// Validadores de rango e identificadores para los payloads de notas
/// (cognitivas, conducta y adicionales). Rechazan payloads corruptos con
/// mensajes de negocio antes de que se persistan.
///
/// Nota de escala: la calificación se valida en el rango [<see cref="MinValue"/>, <see cref="MaxValue"/>]
/// (vigesimal). El valor 0 es una calificación VÁLIDA; solo se rechazan negativos
/// y valores fuera del máximo. Ajustar <see cref="MaxValue"/> si alguna escala difiere.
/// </summary>
internal static class QualificationGradeRange
{
    internal const double MinValue = 0;

    internal const double MaxValue = 20;
}

public class AbilityGradeValidator : AbstractValidator<AbilityGradeDto>
{
    public AbilityGradeValidator()
    {
        this.RuleFor(x => x.Value)
            .InclusiveBetween(QualificationGradeRange.MinValue, QualificationGradeRange.MaxValue)
            .WithMessage($"Una nota de criterio está fuera del rango permitido ({QualificationGradeRange.MinValue} a {QualificationGradeRange.MaxValue})");

        this.RuleFor(x => x.CriteriaId).GreaterThan(0).WithMessage("No se ha indicado el criterio de una nota cognitiva");
        this.RuleFor(x => x.StudentId).GreaterThan(0).WithMessage("No se ha indicado el estudiante de una nota cognitiva");
        this.RuleFor(x => x.WorkerId).GreaterThan(0).WithMessage("No se ha indicado el docente de una nota cognitiva");
        this.RuleFor(x => x.UnityId).GreaterThan(0).WithMessage("No se ha indicado la unidad de una nota cognitiva");
        this.RuleFor(x => x.SubjectId).GreaterThan(0).WithMessage("No se ha indicado la asignatura de una nota cognitiva");
        this.RuleFor(x => x.Year).GreaterThan(0).WithMessage("No se ha indicado el año de una nota cognitiva");
    }
}

public class CompetenceGradeValidator : AbstractValidator<CompetenceGradeDto>
{
    public CompetenceGradeValidator()
    {
        this.RuleFor(x => x.Value)
            .InclusiveBetween(QualificationGradeRange.MinValue, QualificationGradeRange.MaxValue)
            .WithMessage($"Una nota de competencia está fuera del rango permitido ({QualificationGradeRange.MinValue} a {QualificationGradeRange.MaxValue})");

        this.RuleFor(x => x.CompetenceId).GreaterThan(0).WithMessage("No se ha indicado la competencia de una nota cognitiva");
        this.RuleFor(x => x.StudentId).GreaterThan(0).WithMessage("No se ha indicado el estudiante de una nota cognitiva");
        this.RuleFor(x => x.WorkerId).GreaterThan(0).WithMessage("No se ha indicado el docente de una nota cognitiva");
        this.RuleFor(x => x.UnityId).GreaterThan(0).WithMessage("No se ha indicado la unidad de una nota cognitiva");
        this.RuleFor(x => x.SubjectId).GreaterThan(0).WithMessage("No se ha indicado la asignatura de una nota cognitiva");
        this.RuleFor(x => x.Year).GreaterThan(0).WithMessage("No se ha indicado el año de una nota cognitiva");
    }
}

public class UnityGradeValidator : AbstractValidator<UnityGradeDto>
{
    public UnityGradeValidator()
    {
        this.RuleFor(x => x.Value)
            .InclusiveBetween(QualificationGradeRange.MinValue, QualificationGradeRange.MaxValue)
            .WithMessage($"Una nota de unidad está fuera del rango permitido ({QualificationGradeRange.MinValue} a {QualificationGradeRange.MaxValue})");

        this.RuleFor(x => x.Score).GreaterThanOrEqualTo(0).WithMessage("El puntaje de una nota de unidad no puede ser negativo");
        this.RuleFor(x => x.StudentId).GreaterThan(0).WithMessage("No se ha indicado el estudiante de una nota de unidad");
        this.RuleFor(x => x.WorkerId).GreaterThan(0).WithMessage("No se ha indicado el docente de una nota de unidad");
        this.RuleFor(x => x.UnityId).GreaterThan(0).WithMessage("No se ha indicado la unidad de una nota de unidad");
        this.RuleFor(x => x.SubjectId).GreaterThan(0).WithMessage("No se ha indicado la asignatura de una nota de unidad");
        this.RuleFor(x => x.Year).GreaterThan(0).WithMessage("No se ha indicado el año de una nota de unidad");
    }
}

public class CognitiveGradeValidator : AbstractValidator<CognitiveGradeDto>
{
    public CognitiveGradeValidator()
    {
        this.RuleForEach(x => x.AbilityGrades).SetValidator(new AbilityGradeValidator());
        this.RuleForEach(x => x.CompetenceGrades).SetValidator(new CompetenceGradeValidator());
        this.RuleForEach(x => x.UnityGrades).SetValidator(new UnityGradeValidator());
    }
}

public class ConductGradeValidator : AbstractValidator<GenericGradeDto>
{
    public ConductGradeValidator()
    {
        this.RuleFor(x => x.Value)
            .InclusiveBetween(QualificationGradeRange.MinValue, QualificationGradeRange.MaxValue)
            .WithMessage($"Una nota de conducta está fuera del rango permitido ({QualificationGradeRange.MinValue} a {QualificationGradeRange.MaxValue})");

        this.RuleFor(x => x.StudentId).GreaterThan(0).WithMessage("No se ha indicado el estudiante de una nota de conducta");
        this.RuleFor(x => x.EnrollmentId).GreaterThan(0).WithMessage("No se ha indicado la matrícula de una nota de conducta");
        this.RuleFor(x => x.WorkerId).GreaterThan(0).WithMessage("No se ha indicado el docente de una nota de conducta");
        this.RuleFor(x => x.UnityId).GreaterThan(0).WithMessage("No se ha indicado la unidad de una nota de conducta");
        this.RuleFor(x => x.Year).GreaterThan(0).WithMessage("No se ha indicado el año de una nota de conducta");
    }
}

public class AdditionalGradeItemValidator : AbstractValidator<GenericGradeDto>
{
    public AdditionalGradeItemValidator()
    {
        this.RuleFor(x => x.Value)
            .InclusiveBetween(QualificationGradeRange.MinValue, QualificationGradeRange.MaxValue)
            .WithMessage($"Una nota actitudinal o procedimental está fuera del rango permitido ({QualificationGradeRange.MinValue} a {QualificationGradeRange.MaxValue})");

        this.RuleFor(x => x.StudentId).GreaterThan(0).WithMessage("No se ha indicado el estudiante de una nota adicional");
        this.RuleFor(x => x.WorkerId).GreaterThan(0).WithMessage("No se ha indicado el docente de una nota adicional");
        this.RuleFor(x => x.UnityId).GreaterThan(0).WithMessage("No se ha indicado la unidad de una nota adicional");
        this.RuleFor(x => x.GradeId).GreaterThan(0).WithMessage("No se ha indicado el grado de una nota adicional");
        this.RuleFor(x => x.Year).GreaterThan(0).WithMessage("No se ha indicado el año de una nota adicional");
    }
}

public class AdditionalGradeValidator : AbstractValidator<AdditionalGradeDto>
{
    public AdditionalGradeValidator()
    {
        this.RuleForEach(x => x.AptitudeGrades).SetValidator(new AdditionalGradeItemValidator());
        this.RuleForEach(x => x.ProceduralGrades).SetValidator(new AdditionalGradeItemValidator());
    }
}
