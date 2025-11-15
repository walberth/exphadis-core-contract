// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Mapper;

public class StudentProfile : Profile
{
    public StudentProfile()
    {
        this.CreateMap<StudentList, StudentListDto>()
            ?.ForMember(dest => dest.IdPerson, opt => opt?.MapFrom(src => src.IdPerson))
            ?.ForMember(dest => dest.IdStudent, opt => opt?.MapFrom(src => src.IdStudent))
            ?.ForMember(dest => dest.CompleteName, opt => opt?.MapFrom(src => src.CompleteName))
            ?.ForMember(dest => dest.Grade, opt => opt?.MapFrom(src => src.Grade))
            ?.ForMember(dest => dest.Telephone, opt => opt?.MapFrom(src => src.Telephone))
            ?.ForMember(dest => dest.Document, opt => opt?.MapFrom(src => src.Document))
            ?.ForMember(dest => dest.DocumentAttorney, opt => opt?.MapFrom(src => src.DocumentAttorney))
            ?.ForMember(dest => dest.Age, opt => opt?.MapFrom(src => src.Age))
            ?.ForMember(dest => dest.IdAttorney, opt => opt?.MapFrom(src => src.IdAttorney))
            ?.ForMember(dest => dest.IdGrade, opt => opt?.MapFrom(src => src.IdGrade))
            ?.ForMember(dest => dest.IdLevel, opt => opt?.MapFrom(src => src.IdLevel))
            ?.ForMember(dest => dest.IdSection, opt => opt?.MapFrom(src => src.IdSection))
            ?.ForMember(dest => dest.LastYearEnrollment, opt => opt?.MapFrom(src => src.LastYearEnrollment))
            ?.ForMember(dest => dest.TotalStudent, opt => opt?.MapFrom(src => src.TotalStudent))
            ?.ReverseMap();

        this.CreateMap<AttorneyInformation, AttorneyInformationDto>()
            ?.ReverseMap();

        this.CreateMap<ParentsInformation, ParentsInformationDto>()
            ?.ReverseMap();

        this.CreateMap<Student, StudentEnrollmentDto>()
            ?.ForMember(dest => dest.IdStudent, opt => opt?.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.CompleteName, opt => opt?.MapFrom(src => $"{src.Person.CompleteName}"))
            ?.ForMember(dest => dest.Year, opt => opt?.MapFrom(src => $"{src.Enrollment.Year}"))
            ?.ForMember(dest => dest.IdLevel, opt => opt?.Ignore())
            ?.ForMember(dest => dest.IdGrade, opt => opt?.Ignore())
            ?.ForMember(dest => dest.Grade, opt => opt?.Ignore())
            ?.ForMember(dest => dest.IdSection, opt => opt?.Ignore())
            ?.ForMember(dest => dest.Section, opt => opt?.Ignore())
            ?.ForMember(dest => dest.State, opt => opt?.Ignore());

        this.CreateMap<Enrollment, StudentEnrollmentDto>()
            ?.ForMember(dest => dest.EnrollmentId, opt => opt?.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.CompleteName, opt => opt?.MapFrom(src => $"{src.Student.Person.CompleteName}"))
            ?.ForMember(dest => dest.IdLevel, opt => opt?.MapFrom(src => $"{src.IdLevel}"))
            ?.ForMember(dest => dest.Level, opt => opt?.MapFrom(src => $"{src.Level.Name}"))
            ?.ForMember(dest => dest.IdGrade, opt => opt?.MapFrom(src => $"{src.IdGrade}"))
            ?.ForMember(dest => dest.Grade, opt => opt?.MapFrom(src => $"{src.Grade.Name}"))
            ?.ForMember(dest => dest.IdSection, opt => opt?.MapFrom(src => $"{src.IdSection}"))
            ?.ForMember(dest => dest.Section, opt => opt?.MapFrom(src => $"{src.Section.Name}"))
            ?.ForMember(dest => dest.Year, opt => opt?.MapFrom(src => $"{src.Year}"))
            ?.ForMember(dest => dest.IdStudent, opt => opt?.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.IdAttorney, opt => opt?.MapFrom(src => $"{src.Student.IdAttorney}"))
            ?.ForMember(dest => dest.IdPerson, opt => opt?.MapFrom(src => $"{src.Student.IdPerson}"))
            ?.ForMember(dest => dest.PensionAmountByStudent, opt => opt?.Ignore())
            ?.ForMember(dest => dest.State, opt => opt?.Ignore());

        this.CreateMap<Student, StudentDto>()
            ?.ForMember(dest => dest.Id, opt => opt?.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.IdAttorney, opt => opt?.MapFrom(src => src.IdAttorney))
            ?.ForMember(dest => dest.IdPersonLive, opt => opt?.MapFrom(src => src.IdPersonLive))
            ?.ForMember(dest => dest.StudentCertificate, opt => opt?.MapFrom(src => src.StudentCertificate))
            ?.ForMember(dest => dest.BrothersNumber, opt => opt?.MapFrom(src => src.BrothersNumber))
            ?.ForMember(dest => dest.IdReference, opt => opt?.MapFrom(src => src.IdReference))
            ?.ForMember(dest => dest.Comment, opt => opt?.MapFrom(src => src.Comment))
            ?.ForMember(dest => dest.UserRegister, opt => opt?.MapFrom(src => src.UserRegister))
            ?.ForMember(dest => dest.UserUpdated, opt => opt?.MapFrom(src => src.UserUpdated))
            ?.ForMember(dest => dest.TimeRegister, opt => opt?.MapFrom(src => src.TimeRegister))
            ?.ForMember(dest => dest.TimeUpdated, opt => opt?.MapFrom(src => src.TimeUpdated))
            ?.ForMember(dest => dest.Person, opt => opt?.MapFrom(src => src.Person))
            ?.ForMember(dest => dest.Attorney, opt => opt?.MapFrom(src => src.Attorney))
            .ReverseMap();

        this.CreateMap<StudentInformation, StudentInformationDto>()
            ?.ForMember(dest => dest.IdPerson, opt => opt?.MapFrom(src => src.IdPerson))
            ?.ForMember(dest => dest.IdStudent, opt => opt?.MapFrom(src => src.IdStudent))
            ?.ForMember(dest => dest.FirstName, opt => opt?.MapFrom(src => src.FirstName))
            ?.ForMember(dest => dest.MotherLastName, opt => opt?.MapFrom(src => src.MotherLastName))
            ?.ForMember(dest => dest.FatherLastName, opt => opt?.MapFrom(src => src.FatherLastName))
            ?.ForMember(dest => dest.Sex, opt => opt?.MapFrom(src => src.Sex))
            ?.ForMember(dest => dest.DocumentType, opt => opt?.MapFrom(src => src.DocumentType))
            ?.ForMember(dest => dest.Document, opt => opt?.MapFrom(src => src.Document))
            ?.ForMember(dest => dest.Email, opt => opt?.MapFrom(src => src.Email))
            ?.ForMember(dest => dest.Mobile, opt => opt?.MapFrom(src => src.Mobile))
            ?.ForMember(dest => dest.Telephone, opt => opt?.MapFrom(src => src.Telephone))
            ?.ForMember(dest => dest.BirthDate, opt => opt?.MapFrom(src => src.BirthDate))
            ?.ForMember(dest => dest.PersonType, opt => opt?.MapFrom(src => src.PersonType))
            ?.ForMember(dest => dest.BrotherNumber, opt => opt?.MapFrom(src => src.BrotherNumber))
            ?.ForMember(dest => dest.StudyCertificate, opt => opt?.MapFrom(src => src.StudyCertificate))
            ?.ForMember(dest => dest.IdReferenceType, opt => opt?.MapFrom(src => src.IdReferenceType))
            ?.ForMember(dest => dest.ReferenceType, opt => opt?.MapFrom(src => src.ReferenceType))
            ?.ReverseMap();
    }
}
