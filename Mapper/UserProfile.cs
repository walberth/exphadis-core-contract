namespace Exphadis.Core.Contract.Mapper;

public class UserProfile : Profile
{
    public UserProfile()
    {
        this.CreateMap<Parent, ParentDto>()
            ?.ForMember(dest => dest.Id, opt => opt?.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.IdStudent, opt => opt?.MapFrom(src => src.IdStudent))
            ?.ForMember(dest => dest.IdRelationshipType, opt => opt?.MapFrom(src => src.IdRelationshipType))
            ?.ForMember(dest => dest.Person, opt => opt?.MapFrom(src => src.Person))
            ?.ForMember(dest => dest.RelationshipType, opt => opt?.MapFrom(src => src.Relationship))
            ?.ReverseMap();

        this.CreateMap<Person, PersonDto>()
            ?.ForMember(dest => dest.Id, opt => opt?.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.FirstName, opt => opt?.MapFrom(src => src.FirstName))
            ?.ForMember(dest => dest.MotherLastName, opt => opt?.MapFrom(src => src.MotherLastName))
            ?.ForMember(dest => dest.FatherLastName, opt => opt?.MapFrom(src => src.FatherLastName))
            ?.ForMember(dest => dest.Sex, opt => opt?.MapFrom(src => src.Sex))
            ?.ForMember(dest => dest.CompleteName, opt => opt?.MapFrom(src => src.CompleteName))
            ?.ForMember(dest => dest.BirthDate, opt => opt?.MapFrom(src => src.BirthDate))
            ?.ForMember(dest => dest.Age, opt => opt?.MapFrom(src => src.Age))
            ?.ForMember(dest => dest.PersonType, opt => opt?.MapFrom(src => src.PersonType))
            ?.ForMember(dest => dest.BusinessName, opt => opt?.MapFrom(src => src.BusinessName))
            ?.ForMember(dest => dest.DocumentType, opt => opt?.MapFrom(src => src.DocumentType))
            ?.ForMember(dest => dest.Document, opt => opt?.MapFrom(src => src.Document))
            ?.ForMember(dest => dest.Email, opt => opt?.MapFrom(src => src.Email))
            ?.ForMember(dest => dest.Mobile, opt => opt?.MapFrom(src => src.Mobile))
            ?.ForMember(dest => dest.Telephone, opt => opt?.MapFrom(src => src.Telephone))
            ?.ForMember(dest => dest.ImageUrl, opt => opt?.MapFrom(src => src.ImageUrl))
            ?.ForMember(dest => dest.UserRegister, opt => opt?.MapFrom(src => src.UserRegister))
            ?.ForMember(dest => dest.UserUpdated, opt => opt?.MapFrom(src => src.UserUpdated))
            ?.ForMember(dest => dest.TimeRegister, opt => opt?.MapFrom(src => src.TimeRegister))
            ?.ForMember(dest => dest.TimeUpdated, opt => opt?.MapFrom(src => src.TimeUpdated))
            ?.ReverseMap();

        this.CreateMap<UserInformationDto, PersonDto>()
            ?.ForMember(dest => dest.FirstName, opt => opt?.MapFrom(src => src.FirstName))
            ?.ForMember(dest => dest.MotherLastName, opt => opt?.MapFrom(src => src.MotherLastName))
            ?.ForMember(dest => dest.FatherLastName, opt => opt?.MapFrom(src => src.FatherLastName))
            ?.ForMember(dest => dest.Sex, opt => opt?.MapFrom(src => src.Sex))
            ?.ForMember(dest => dest.BirthDate, opt => opt?.MapFrom(src => src.BirthDate))
            ?.ForMember(dest => dest.PersonType, opt => opt?.MapFrom(src => src.PersonType))
            ?.ForMember(dest => dest.BusinessName, opt => opt?.MapFrom(src => src.BusinessName))
            ?.ForMember(dest => dest.DocumentType, opt => opt?.MapFrom(src => src.DocumentType))
            ?.ForMember(dest => dest.Document, opt => opt?.MapFrom(src => src.Document))
            ?.ForMember(dest => dest.Email, opt => opt?.MapFrom(src => src.Email))
            ?.ReverseMap();

        this.CreateMap<Direction, DirectionDto>()
            ?.ForMember(dest => dest.Id, opt => opt?.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.IdPerson, opt => opt?.MapFrom(src => src.IdPerson))
            ?.ForMember(dest => dest.Direction, opt => opt?.MapFrom(src => src.Reference))
            ?.ForMember(dest => dest.IdDistrict, opt => opt?.MapFrom(src => src.IdDistrict))
            ?.ForMember(dest => dest.IdProvince, opt => opt?.MapFrom(src => src.IdProvince))
            ?.ForMember(dest => dest.IdDepartment, opt => opt?.MapFrom(src => src.IdDepartment));

        this.CreateMap<DirectionDto, Direction>()
            ?.ForMember(dest => dest.Id, opt => opt?.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.IdPerson, opt => opt?.MapFrom(src => src.IdPerson))
            ?.ForMember(dest => dest.Reference, opt => opt?.MapFrom(src => src.Direction))
            ?.ForMember(dest => dest.IdDistrict, opt => opt?.MapFrom(src => src.IdDistrict))
            ?.ForMember(dest => dest.IdProvince, opt => opt?.MapFrom(src => src.IdProvince))
            ?.ForMember(dest => dest.IdDepartment, opt => opt?.MapFrom(src => src.IdDepartment));

        this.CreateMap<Person, ContactDto>()
            ?.ForMember(dest => dest.Id, opt => opt?.MapFrom(src => $"{src.Document}"))
            ?.ForMember(dest => dest.ImageUrl, opt => opt?.MapFrom(src => $"{src.ImageUrl}"))
            ?.ForMember(dest => dest.CompleteName, opt => opt?.MapFrom(src => $"{src.CompleteName}"));

        this.CreateMap<UserRole, UserRoleDto>()
            ?.ReverseMap();

        this.CreateMap<User, UserDto>()
            ?.ForMember(dest => dest.Id, opt => opt?.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.IdPerson, opt => opt?.MapFrom(src => src.IdPerson))
            ?.ForMember(dest => dest.Username, opt => opt?.MapFrom(src => src.Username))
            ?.ForMember(dest => dest.Password, opt => opt?.MapFrom(src => src.Password))
            ?.ForMember(dest => dest.Active, opt => opt?.MapFrom(src => src.Active))
            ?.ForMember(dest => dest.RoleList, opt => opt?.MapFrom(src => src.RoleList))
            ?.ForMember(dest => dest.CompleteName, opt => opt?.MapFrom(src => $"{src.Person.CompleteName}"))
            ?.ForMember(dest => dest.Roles, opt => opt?.Ignore())
            ?.ForMember(dest => dest.State, opt => opt?.Ignore())
            ?.ForMember(dest => dest.RoleNames, opt => opt?.Ignore());

        this.CreateMap<UserDto, User>()
            ?.ForMember(dest => dest.Id, opt => opt?.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.IdPerson, opt => opt?.MapFrom(src => src.IdPerson))
            ?.ForMember(dest => dest.Username, opt => opt?.MapFrom(src => src.Username))
            ?.ForMember(dest => dest.Password, opt => opt?.MapFrom(src => src.Password))
            ?.ForMember(dest => dest.Active, opt => opt?.MapFrom(src => src.Active))
            ?.ForMember(dest => dest.Comment, opt => opt?.Ignore())
            ?.ForMember(dest => dest.Person, opt => opt?.Ignore())
            ?.ForMember(dest => dest.RoleNames, opt => opt?.Ignore())
            ?.ForMember(dest => dest.Roles, opt => opt?.Ignore())
            ?.ForMember(dest => dest.HardReloading, opt => opt?.Ignore())
            ?.ForMember(dest => dest.UserRoles, opt => opt?.Ignore())
            ?.ForMember(dest => dest.Sessions, opt => opt?.Ignore())
            ?.ForMember(dest => dest.RoleList, opt => opt?.Ignore());

        this.CreateMap<PersonList, PersonListDto>()
            ?.ReverseMap();

        this.CreateMap<GradeInstruction, GradeInstructionTypeDto>()
            ?.ReverseMap();

        this.CreateMap<RelationshipType, RelationshipTypeDto>()
            ?.ReverseMap();

        this.CreateMap<PersonType, PersonTypeDto>()
            ?.ReverseMap();

        this.CreateMap<Document, DocumentTypeDto>()
            ?.ReverseMap();

        this.CreateMap<Department, DepartmentDto>()
            ?.ReverseMap();

        this.CreateMap<Province, ProvinceDto>()
            ?.ReverseMap();
    }
}
