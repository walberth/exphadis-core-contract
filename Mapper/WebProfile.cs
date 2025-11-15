namespace Exphadis.Core.Contract.Mapper;

public class WebProfile : Profile
{
    public WebProfile()
    {
        this.CreateMap<Menu, MenuDto>()
            ?.ForMember(dest => dest.Id, opt => opt?.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt?.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Description, opt => opt?.MapFrom(src => src.Description))
            ?.ForMember(dest => dest.Icon, opt => opt?.MapFrom(src => src.Icon))
            ?.ForMember(dest => dest.Order, opt => opt?.MapFrom(src => src.Order))
            ?.ForMember(dest => dest.RedirectTo, opt => opt?.MapFrom(src => src.RedirectTo))
            ?.ForMember(dest => dest.Active, opt => opt?.MapFrom(src => src.Active))
            ?.ForMember(dest => dest.RedirectTo, opt => opt?.MapFrom(src => src.RedirectTo))
            ?.ForMember(dest => dest.NumberOfChildrens, opt => opt?.MapFrom(src => $"{src.ChildrenList.Count}"))
            ?.ForMember(dest => dest.Childrens, opt => opt?.Ignore());
    }
}
