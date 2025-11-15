namespace Exphadis.Core.Contract.Dto;

using Base;

public class EnrollmentDto : AuditDto
{
    public int Id { get; set; }

    public int IdStudent { get; set; }

    public int IdLevel { get; set; }

    public int IdGrade { get; set; }

    public int IdTurn { get; set; }

    public int IdSection { get; set; }

    public int Year { get; set; }

    public int IdPaymentPlan { get; set; }

    public int IdDiscountPlan { get; set; }

    public bool HaveDiscount { get; set; }

    public string Observation { get; set; }

    public string ImageUrl { get; set; }

    public bool Active { get; set; }

    public decimal PensionAmountByStudent { get; set; }

    public bool Scholarship { get; set; }

    public int IdMedia { get; set; }

    public int PensionDay { get; set; }

    public int StartPensionMonth { get; set; }

    public int EndServiceMonth { get; set; }

    public StudentDto Student { get; set; }

    public LevelDto Level { get; set; }

    public GradeDto Grade { get; set; }

    public TurnDto Turn { get; set; }

    public SectionDto Section { get; set; }

    public decimal AreaNotesAverage { get; set; }

    public decimal AreaNotesScore { get; set; }

    public DateTime? DateRetire { get; set; }

    public List<AreaNoteDto> AreaNotes { get; set; } = new List<AreaNoteDto>();
}
