// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Dto;

public class EnrollmentListDto
{
    public int IdEnrollment { get; set; }

    public int IdStudent { get; set; }

    public int IdPerson { get; set; }

    public int IdAttorney { get; set; }

    public string CompleteName { get; set; }

    public int IdLevel { get; set; }

    public string Level { get; set; }

    public int IdGrade { get; set; }

    public string Grade { get; set; }

    public int IdTurn { get; set; }

    public string Turn { get; set; }

    public int IdSection { get; set; }

    public string Section { get; set; }

    public string Payment { get; set; }

    public string Discount { get; set; }

    public string Telephone { get; set; }

    public int Year { get; set; }

    public int StartPensionMonth { get; set; }

    public int EndServiceMonth { get; set; }

    public string DocumentAttorney { get; set; }

    public string ImageUrl { get; set; }

    public int IdPayment { get; set; }

    public int IdDiscount { get; set; }

    public bool HaveDiscount { get; set; }

    public string UserRegister { get; set; }

    public DateTime TimeRegister { get; set; }

    public bool Active { get; set; }

    public string Observation { get; set; }

    public int IdMedia { get; set; }

    public int PensionDay { get; set; }

    public bool Scholarship { get; set; }

    public decimal PensionAmountByStudent { get; set; }

    public string PensionAmountByStudentForPresentation => $"S/.{this.PensionAmountByStudent:N2}";

    public DateTime? DateRetire { get; set; }

    public string TotalSubjects { get; set; }
}
