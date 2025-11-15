// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Mapper;

public class AttorneyProfile : Profile
{
    public AttorneyProfile()
    {
        this.CreateMap<Attorney, AttorneyDto>()
            ?.ForMember(dest => dest.Id, opt => opt?.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Person, opt => opt?.MapFrom(src => src.Person))
            ?.ForMember(dest => dest.IdGradeIntruction, opt => opt?.MapFrom(src => src.IdGradeInstruction))
            ?.ForMember(dest => dest.IdRelationshipType, opt => opt?.MapFrom(src => src.IdRelationship))
            ?.ForMember(dest => dest.Workcenter, opt => opt?.MapFrom(src => src.WorkCenter))
            ?.ForMember(dest => dest.Ocupation, opt => opt?.MapFrom(src => src.Occupation))
            ?.ForMember(dest => dest.UserRegister, opt => opt?.MapFrom(src => src.UserRegister))
            ?.ForMember(dest => dest.UserUpdated, opt => opt?.MapFrom(src => src.UserUpdated))
            ?.ForMember(dest => dest.TimeRegister, opt => opt?.MapFrom(src => src.TimeRegister))
            ?.ForMember(dest => dest.TimeUpdated, opt => opt?.MapFrom(src => src.TimeUpdated))
            .ReverseMap();

        this.CreateMap<AttorneyInformation, AttorneyInformationDto>()
            ?.ReverseMap();

        this.CreateMap<ParentsInformation, ParentsInformationDto>()
            ?.ReverseMap();
    }
}
