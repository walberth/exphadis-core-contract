// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Dto;

using Base;

public class StudentDto : AuditDto
{
    public int Id { get; set; }

    public int IdAttorney { get; set; }

    public int IdPersonLive { get; set; }

    public bool? StudentCertificate { get; set; }

    public int? BrothersNumber { get; set; }

    public int? IdReference { get; set; }

    public string Comment { get; set; }

    public PersonDto Person { get; set; }

    public AttorneyDto Attorney { get; set; }
}

public class StudentEnrollmentDto
{
    public int EnrollmentId { get; set; }

    public string CompleteName { get; set; }

    public string Document { get; set; }

    public int IdLevel { get; set; }

    public string Level { get; set; }

    public int IdGrade { get; set; }

    public string Grade { get; set; }

    public int IdSection { get; set; }

    public string Section { get; set; }

    public int Year { get; set; }

    public string State { get; set; }

    public int IdStudent { get; set; }

    public int IdAttorney { get; set; }

    public int IdPerson { get; set; }

    public decimal PensionAmountByStudent { get; set; }
}

public class StudentBankPaymentDto
{
    public IncomeAndExpensesDto IncomeAndExpenses { get; set; }

    public StudentPaymentDto StudentPayment { get; set; }

    public BankPaymentDto BankPayment { get; set; }
}

public class StudentCompleteInformationDto
{
    public StudentInformationDto Student { get; set; } = new StudentInformationDto();

    public AttorneyInformationDto Attorney { get; set; } = new AttorneyInformationDto();

    public IEnumerable<ParentsInformationDto> Parents { get; set; } = new List<ParentsInformationDto>();
}

public class StudentInformationDto
{
    public int IdPerson { get; set; }

    public int IdStudent { get; set; }

    public string FirstName { get; set; }

    public string MotherLastName { get; set; }

    public string FatherLastName { get; set; }

    public bool Sex { get; set; }

    public int DocumentType { get; set; }

    public string Document { get; set; }

    public string Email { get; set; }

    public string Mobile { get; set; }

    public string Telephone { get; set; }

    public DateTime BirthDate { get; set; }

    public int PersonType { get; set; }

    public bool StudyCertificate { get; set; }

    public int BrotherNumber { get; set; }

    public int IdReferenceType { get; set; }

    public string ReferenceType { get; set; }

    public IEnumerable<DirectionDto> Directions { get; set; } = new List<DirectionDto>();
}

public class StudentListDto
{
    public int Number { get; set; }

    public int IdPerson { get; set; }

    public int IdStudent { get; set; }

    public string CompleteName { get; set; }

    public string Grade { get; set; }

    public string Telephone { get; set; }

    public string Document { get; set; }

    public string DocumentAttorney { get; set; }

    public int Age { get; set; }

    public int IdAttorney { get; set; }

    public int IdGrade { get; set; }

    public int IdLevel { get; set; }

    public int IdSection { get; set; }

    public string LastYearEnrollment { get; set; }

    public int TotalStudent { get; set; }

    public string UserRegister { get; set; }

    public DateTime TimeRegister { get; set; }

    public string PensionAmountByStudent { get; set; }
}

public class StudentNormalPaymentDto
{
    public IncomeAndExpensesDto IncomeAndExpenses { get; set; }

    public StudentPaymentDto StudentPayment { get; set; }
}

public class StudentPaymentDto : AuditDto
{
    public int Id { get; set; }

    public int IdStudent { get; set; }

    public decimal Amount { get; set; }

    public int IdPaymentMethod { get; set; }

    public string Detail { get; set; }

    public string Month { get; set; }

    public int Year { get; set; }

    public MoneyMovementTypeEnum IncomeMoneyMovementTypeEnum { get; set; }

    public int IdAttorney { get; set; }

    public bool Completed { get; set; }

    public string PaymentRelatedInformation { get; set; }

    public int IdIncomeExpense { get; set; }

    public bool Validated { get; set; }

    public string Invoice { get; set; }

    public string TicketUrl { get; set; }

    public bool ShouldBeTaken { get; set; }

    public DateTime PaymentDate { get; set; }

    public string Correlative { get; set; }

    public string Message { get; set; }

    public decimal ArrearsAmount { get; set; }

    public int Commitment { get; set; }

    public int IdSection { get; set; }

    public int IdLevel { get; set; }

    public int IdGrade { get; set; }

    public int IdPerson { get; set; }

    public DateTime PensionDay { get; set; }

    public string CompleteName { get; set; }

    public string MoneyMovement { get; set; }

    public string PaymentMethod { get; set; }

    public bool CompletedArrears { get; set; }

    public IEnumerable<int> PaymentsRelated { get; set; } = new List<int>();

    public int IdStudentPayment { get; set; }

    public int IdBankPayment { get; set; }

    public string DocumentAttorney { get; set; }

    public StudentDto Student { get; set; }

    public IncomeAndExpensesDto IncomeAndExpenses { get; set; }

    public PaymentTypeDto PaymentType { get; set; }

    public MoneyMovementTypeDto MoneyMovementType { get; set; }

    public AttorneyDto Attorney { get; set; }

    public BankPaymentDto BankPayment { get; set; }

    public string DetailPresentation { get; set; }

    public string CompleteValue { get; set; }

    public string TicketValue { get; set; }

    public int NumberLinkedPayment { get; set; }

    public decimal PendingAmount { get; set; }

    public decimal PensionAmountByStudent { get; set; }
}

public class StudentPromotionDto
{
    public int Id { get; set; }

    public int IdPromotion { get; set; }

    public int IdStudent { get; set; }

    public int IdEnrollment { get; set; }

    public int FechaRegistro { get; set; }

    public string StudentName { get; set; }

    public string PromotionType { get; set; }

    public decimal PromotionTypeValue { get; set; }

    public decimal PromotionValue { get; set; }

    public string Year { get; set; }
}

public class StudentQualificationDto
{
    public int StudentId { get; set; }

    public string StudentName { get; set; }

    public IEnumerable<CompetenceGradeDto> CompetenceGrades { get; set; } = new HashSet<CompetenceGradeDto>();

    public IEnumerable<AbilityGradeDto> AbilityGrades { get; set; } = new HashSet<AbilityGradeDto>();

    public UnityGradeDto UnityGrade { get; set; } = new();
}

public class StudentAdditionalQualificationDto
{
    public int StudentId { get; set; }

    public string StudentName { get; set; }

    public int EnrollmentId { get; set; }

    public int Year { get; set; }

    public GenericGradeDto ProceduralQualification { get; set; }

    public GenericGradeDto AptitudeQualification { get; set; }
}

public class StudentRegisterDto
{
    public StudentDto Student { get; set; }

    public IEnumerable<ParentDto> Parents { get; set; }
}

public class InvoicePaymentDto
{
    [Required]
    public int Month { get; set; }

    [Required]
    public int Year { get; set; }

    [Required]
    public MoneyMovementTypeEnum MoneyMovementType { get; set; }

    public string Data { get; set; }

    public string FileName { get; set; }

    [Required]
    public string UserUploaded { get; set; }

    [Required]
    public DateTime DateUploaded { get; set; }
}

public class PaymentPlanByStudentDto : AuditDto
{
    public int Id { get; set; }

    public DateTime? PaymentDate { get; set; }

    public bool? IsComplete { get; set; }

    public int MoneyMovementTypeId { get; set; }

    public int EnrollmentId { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public decimal Amount { get; set; }

    public bool? HaveInvoice { get; set; }

    public string Invoice { get; set; }

    public int PaymentId { get; set; }

    public bool? HaveCommitments { get; set; }

    public bool StudentIsActive { get; set; }

    public bool PaymentIsActive { get; set; }

    public string Comments { get; set; }
}
