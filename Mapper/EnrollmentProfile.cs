// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Mapper;

public class EnrollmentProfile : Profile
{
    public EnrollmentProfile()
    {
        this.CreateMap<Enrollment, EnrollmentDto>()
            ?.ReverseMap();

        this.CreateMap<EnrollmentList, EnrollmentListDto>()
            ?.ForMember(dest => dest.IdEnrollment, opt => opt.MapFrom(src => src.IdEnrollment))
            ?.ForMember(dest => dest.IdStudent, opt => opt.MapFrom(src => src.IdStudent))
            ?.ForMember(dest => dest.IdPerson, opt => opt.MapFrom(src => src.IdPerson))
            ?.ForMember(dest => dest.IdAttorney, opt => opt.MapFrom(src => src.IdAttorney))
            ?.ForMember(dest => dest.CompleteName, opt => opt.MapFrom(src => src.CompleteName))
            ?.ForMember(dest => dest.IdLevel, opt => opt.MapFrom(src => src.IdLevel))
            ?.ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.Level))
            ?.ForMember(dest => dest.IdGrade, opt => opt.MapFrom(src => src.IdGrade))
            ?.ForMember(dest => dest.Grade, opt => opt.MapFrom(src => src.Grade))
            ?.ForMember(dest => dest.IdTurn, opt => opt.MapFrom(src => src.IdTurn))
            ?.ForMember(dest => dest.Turn, opt => opt.MapFrom(src => src.Turn))
            ?.ForMember(dest => dest.IdSection, opt => opt.MapFrom(src => src.IdSection))
            ?.ForMember(dest => dest.Section, opt => opt.MapFrom(src => src.Section))
            ?.ForMember(dest => dest.Payment, opt => opt.MapFrom(src => src.Payment))
            ?.ForMember(dest => dest.Discount, opt => opt.MapFrom(src => src.Discount))
            ?.ForMember(dest => dest.Telephone, opt => opt.MapFrom(src => src.Telephone))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ForMember(dest => dest.StartPensionMonth, opt => opt.MapFrom(src => src.StartPensionMonth))
            ?.ForMember(dest => dest.EndServiceMonth, opt => opt.MapFrom(src => src.EndServiceMonth))
            ?.ForMember(dest => dest.DocumentAttorney, opt => opt.MapFrom(src => src.DocumentAttorney))
            ?.ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
            ?.ForMember(dest => dest.IdPayment, opt => opt.MapFrom(src => src.IdPaymentPlan))
            ?.ForMember(dest => dest.IdDiscount, opt => opt.MapFrom(src => src.IdDiscount))
            ?.ForMember(dest => dest.HaveDiscount, opt => opt.MapFrom(src => src.HaveDiscount))
            ?.ForMember(dest => dest.UserRegister, opt => opt.MapFrom(src => src.UserRegister))
            ?.ForMember(dest => dest.TimeRegister, opt => opt.MapFrom(src => src.TimeRegister))
            ?.ForMember(dest => dest.Active, opt => opt.MapFrom(src => src.Active))
            ?.ForMember(dest => dest.Observation, opt => opt.MapFrom(src => src.Observation))
            ?.ForMember(dest => dest.IdMedia, opt => opt.MapFrom(src => src.IdMedia))
            ?.ForMember(dest => dest.PensionDay, opt => opt.MapFrom(src => src.PensionDay))
            ?.ForMember(dest => dest.Scholarship, opt => opt.MapFrom(src => src.Scholarship))
            ?.ForMember(dest => dest.PensionAmountByStudent, opt => opt.MapFrom(src => src.PensionAmountByStudent))
            ?.ForMember(dest => dest.PensionAmountByStudentForPresentation, opt => opt.Ignore())
            ?.ForMember(dest => dest.DateRetire, opt => opt.MapFrom(src => src.DateRetire))
            ?.ForMember(dest => dest.TotalSubjects, opt => opt.Ignore());
    }
}
