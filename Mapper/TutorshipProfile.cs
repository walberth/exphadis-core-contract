// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Mapper;

public class TutorshipProfile : Profile
{
    public TutorshipProfile()
    {
        this.CreateMap<Assistance, AssistanceDto>()
            ?.ReverseMap();

        this.CreateMap<AssistanceJustification, AssistanceJustificationDto>()
            ?.ReverseMap();

        this.CreateMap<TutorshipMessage, TutorshipMessageDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.IdStudent, opt => opt.MapFrom(src => src.IdStudent))
            ?.ForMember(dest => dest.IdTutorship, opt => opt.MapFrom(src => src.IdTutorship))
            ?.ForMember(dest => dest.IdEnrollment, opt => opt.MapFrom(src => src.IdEnrollment))
            ?.ForMember(dest => dest.Type, opt => opt.MapFrom(src => $"{(TutorshipMessageEnum)src.IdTutorshipMessageType}"))
            ?.ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.Message))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year));

        this.CreateMap<TutorshipMessageDto, TutorshipMessage>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.IdStudent, opt => opt.MapFrom(src => src.IdStudent))
            ?.ForMember(dest => dest.IdTutorship, opt => opt.MapFrom(src => src.IdTutorship))
            ?.ForMember(dest => dest.IdEnrollment, opt => opt.MapFrom(src => src.IdEnrollment))
            ?.ForMember(dest => dest.IdTutorshipMessageType, opt => opt.MapFrom(src => $"{(int)src.Type}"))
            ?.ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.Message))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ForMember(dest => dest.Student, opt => opt.Ignore())
            ?.ForMember(dest => dest.Tutorship, opt => opt.Ignore())
            ?.ForMember(dest => dest.Enrollment, opt => opt.Ignore())
            ?.ForMember(dest => dest.TutorshipMessageType, opt => opt.Ignore())
            ?.ForMember(dest => dest.Recommendation, opt => opt.Ignore());

        this.CreateMap<Tutorship, TutorshipDto>()
            ?.ReverseMap();
    }
}
