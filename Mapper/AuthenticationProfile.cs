// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Mapper;

public class AuthenticationProfile : Profile
{
    public AuthenticationProfile()
    {
        this.CreateMap<Role, RoleDto>()
            ?.ForMember(dest => dest.Id, opt => opt?.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt?.MapFrom(src => src.Name))
            ?.ReverseMap();

        this.CreateMap<Permission, PermissionDto>()
            ?.ForMember(dest => dest.Id, opt => opt?.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt?.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Active, opt => opt?.MapFrom(src => src.Active))
            ?.ReverseMap();

        this.CreateMap<Session, SessionDto>()
            ?.ForMember(dest => dest.IdUser, opt => opt?.MapFrom(src => src.IdUser))
            ?.ForMember(dest => dest.IdSession, opt => opt?.MapFrom(src => src.Token ?? string.Empty))
            ?.ForMember(dest => dest.ExpirationHours, opt => opt?.MapFrom(src => src.TimeToRelease ?? string.Empty))
            ?.ForMember(dest => dest.SessionExpirationTime, opt => opt?.MapFrom(src => src.ExpirationTime))
            ?.ReverseMap();

        this.CreateMap<Login, LoginDto>()
            ?.ForMember(dest => dest.UserId, opt => opt?.MapFrom(src => src.IdUser))
            ?.ForMember(dest => dest.PersonId, opt => opt?.MapFrom(src => src.IdPerson))
            ?.ForMember(dest => dest.WorkerId, opt => opt?.MapFrom(src => src.IdWorker))
            ?.ForMember(dest => dest.CompleteName, opt => opt?.MapFrom(src => src.CompleteName))
            ?.ForMember(dest => dest.Sex, opt => opt?.MapFrom(src => src.Sex))
            ?.ForMember(dest => dest.Email, opt => opt?.MapFrom(src => src.Email))
            ?.ForMember(dest => dest.Username, opt => opt?.MapFrom(src => src.Username))
            ?.ForMember(dest => dest.Password, opt => opt?.MapFrom(src => src.Password))
            ?.ForMember(dest => dest.Active, opt => opt?.MapFrom(src => src.Active))
            ?.ForMember(dest => dest.Document, opt => opt?.MapFrom(src => src.Document))
            ?.ForMember(dest => dest.Mobile, opt => opt?.MapFrom(src => src.Mobile))
            ?.ForMember(dest => dest.Telephone, opt => opt?.MapFrom(src => src.Telephone))
            ?.ForMember(dest => dest.BirthDate, opt => opt?.MapFrom(src => src.BirthDate))
            ?.ForMember(dest => dest.Session, opt => opt?.MapFrom(src => src.Session))
            ?.ForMember(dest => dest.UserRegister, opt => opt?.MapFrom(src => src.UserRegister))
            ?.ForMember(dest => dest.TimeRegister, opt => opt?.MapFrom(src => src.TimeRegister))
            ?.ReverseMap();
    }
}
