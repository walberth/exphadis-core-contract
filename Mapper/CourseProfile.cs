// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Mapper;

public class CourseProfile : Profile
{
    public CourseProfile()
    {
        this.CreateMap<Subject, SubjectDto>()
            ?.ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => $"{src.Course.Name}"))
            ?.ForMember(dest => dest.WorkerName, opt => opt.MapFrom(src => $"{src.Worker.Person.CompleteName}"))
            ?.ForMember(dest => dest.Level, opt => opt.MapFrom(src => $"{src.Level.Name}"))
            ?.ForMember(dest => dest.Grade, opt => opt.MapFrom(src => $"{src.Grade.Name}"))
            ?.ForMember(dest => dest.Section, opt => opt.MapFrom(src => $"{src.Section.Name}"))
            ?.ForMember(dest => dest.Turn, opt => opt.MapFrom(src => $"{src.Turn.Name}"))
            ?.ReverseMap();

        this.CreateMap<CriteriaFilled, CriteriaFilledDto>()
            ?.ReverseMap();

        this.CreateMap<SubjectByUnity, SubjectByUnityDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdAsignature))
            ?.ForMember(dest => dest.IdCourse, opt => opt.MapFrom(src => src.IdCourse))
            ?.ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course))
            ?.ForMember(dest => dest.IdLevel, opt => opt.MapFrom(src => src.IdLevel))
            ?.ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.Level))
            ?.ForMember(dest => dest.IdGrade, opt => opt.MapFrom(src => src.IdGrade))
            ?.ForMember(dest => dest.Grade, opt => opt.MapFrom(src => src.Grade))
            ?.ForMember(dest => dest.IdSection, opt => opt.MapFrom(src => src.IdSection))
            ?.ForMember(dest => dest.Section, opt => opt.MapFrom(src => src.Section))
            ?.ForMember(dest => dest.IdTurn, opt => opt.MapFrom(src => src.IdTurn))
            ?.ForMember(dest => dest.Turn, opt => opt.MapFrom(src => src.Turn))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year));

        this.CreateMap<CourseDto, Course>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            ?.ForMember(dest => dest.IdLevel, opt => opt.MapFrom(src => src.IdLevel))
            ?.ForMember(dest => dest.IdArea, opt => opt.MapFrom(src => src.IdArea))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ForMember(dest => dest.UserRegister, opt => opt.MapFrom(src => src.UserRegister))
            ?.ForMember(dest => dest.UserUpdated, opt => opt.MapFrom(src => src.UserUpdated))
            ?.ForMember(dest => dest.TimeRegister, opt => opt.MapFrom(src => src.TimeRegister))
            ?.ForMember(dest => dest.TimeUpdated, opt => opt.MapFrom(src => src.TimeUpdated))
            ?.ForMember(dest => dest.AreaName, opt => opt.Ignore())
            ?.ForMember(dest => dest.LevelName, opt => opt.Ignore())
            ?.ForMember(dest => dest.Subject, opt => opt.Ignore())
            ?.ForMember(dest => dest.Area, opt => opt.Ignore())
            ?.ForMember(dest => dest.Level, opt => opt.Ignore());

        this.CreateMap<Course, CourseDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            ?.ForMember(dest => dest.IdLevel, opt => opt.MapFrom(src => src.IdLevel))
            ?.ForMember(dest => dest.IdArea, opt => opt.MapFrom(src => src.IdArea))
            ?.ForMember(dest => dest.AreaName, opt => opt.MapFrom(src => $"{src.Area.Name}"))
            ?.ForMember(dest => dest.Level, opt => opt.MapFrom(src => $"{src.Level.Name}"))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ForMember(dest => dest.UserRegister, opt => opt.MapFrom(src => src.UserRegister))
            ?.ForMember(dest => dest.UserUpdated, opt => opt.MapFrom(src => src.UserUpdated))
            ?.ForMember(dest => dest.TimeRegister, opt => opt.MapFrom(src => src.TimeRegister))
            ?.ForMember(dest => dest.TimeUpdated, opt => opt.MapFrom(src => src.TimeUpdated));

        this.CreateMap<AreaDto, Area>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            ?.ForMember(dest => dest.IdLevel, opt => opt.MapFrom(src => src.IdLevel))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ForMember(dest => dest.UserRegister, opt => opt.MapFrom(src => src.UserRegister))
            ?.ForMember(dest => dest.UserUpdated, opt => opt.MapFrom(src => src.UserUpdated))
            ?.ForMember(dest => dest.TimeRegister, opt => opt.MapFrom(src => src.TimeRegister))
            ?.ForMember(dest => dest.TimeUpdated, opt => opt.MapFrom(src => src.TimeUpdated))
            ?.ReverseMap();

        this.CreateMap<CertificateCourse, CertificateCourseDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.IdLevel, opt => opt.MapFrom(src => src.IdLevel))
            ?.ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.Level.Name))
            ?.ForMember(dest => dest.UserRegister, opt => opt.MapFrom(src => src.UserRegister))
            ?.ForMember(dest => dest.CertificateNote, opt => opt.MapFrom(src => src.CertificateNote))
            ?.ReverseMap();

        this.CreateMap<CertificateCourseDto, CertificateCourse>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.IdLevel, opt => opt.MapFrom(src => src.IdLevel))
            ?.ForMember(dest => dest.Level, opt => opt.Ignore())
            ?.ForMember(dest => dest.UserRegister, opt => opt.MapFrom(src => src.UserRegister))
            ?.ForMember(dest => dest.CertificateNote, opt => opt.MapFrom(src => src.CertificateNote))
            ?.ReverseMap();

        this.CreateMap<WorkshopConfiguration, WorkshopConfigurationDto>()
            ?.ForMember(dest => dest.NumberSessions, opt => opt.MapFrom(src => src.Sessions))
            ?.ForMember(dest => dest.WeekDays, opt => opt.Ignore())
            ?.ReverseMap();

        this.CreateMap<WorkshopInscription, WorkshopInscriptionDto>()
            ?.ForMember(dest => dest.IdWorkshop, opt => opt.MapFrom(src => src.IdWorkshopConfiguration))
            ?.ReverseMap();

        this.CreateMap<WorkshopResult, WorkshopResultDto>()
            ?.ForMember(dest => dest.IdWorkshopState, opt => opt.MapFrom(src => src.IdWorkshopResultState))
            ?.ReverseMap();
    }
}
