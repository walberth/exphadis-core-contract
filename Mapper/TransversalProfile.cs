namespace Exphadis.Core.Contract.Mapper;

public class TransversalProfile : Profile
{
    public TransversalProfile()
    {
        this.CreateMap<AuditEntity, AuditDto>()
            ?.ForMember(dest => dest.TimeRegister, opt => opt?.MapFrom(src => src.TimeRegister))
            ?.ForMember(dest => dest.TimeUpdated, opt => opt?.MapFrom(src => src.TimeUpdated))
            ?.ForMember(dest => dest.UserRegister, opt => opt?.MapFrom(src => src.UserRegister))
            ?.ForMember(dest => dest.UserUpdated, opt => opt?.MapFrom(src => src.UserUpdated));

        this.CreateMap<AuditDto, AuditEntity>()
            ?.ForMember(dest => dest.TimeRegister, opt => opt?.MapFrom(src => src.TimeRegister))
            ?.ForMember(dest => dest.TimeUpdated, opt => opt?.MapFrom(src => src.TimeUpdated))
            ?.ForMember(dest => dest.UserRegister, opt => opt?.MapFrom(src => src.UserRegister))
            ?.ForMember(dest => dest.UserUpdated, opt => opt?.MapFrom(src => src.UserUpdated));

        this.CreateMap<HardReloading, HardReloadingDto>()
            ?.ForMember(dest => dest.UserId, opt => opt?.MapFrom(src => src.UserId))
            ?.ForMember(dest => dest.TimeStamp, opt => opt?.MapFrom(src => src.TimeStamp))
            ?.ForMember(dest => dest.Ip, opt => opt?.MapFrom(src => src.Ip))
            ?.ForMember(dest => dest.Browser, opt => opt?.MapFrom(src => src.Browser));

        this.CreateMap<HardReloadingDto, HardReloading>()
            ?.ForMember(dest => dest.UserId, opt => opt?.MapFrom(src => src.UserId))
            ?.ForMember(dest => dest.TimeStamp, opt => opt?.MapFrom(src => src.TimeStamp))
            ?.ForMember(dest => dest.Ip, opt => opt?.MapFrom(src => src.Ip))
            ?.ForMember(dest => dest.Browser, opt => opt?.MapFrom(src => src.Browser))
            ?.ForMember(dest => dest.Id, opt => opt.Ignore())
            ?.ForMember(dest => dest.User, opt => opt.Ignore());
    }
}
