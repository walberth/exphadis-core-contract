namespace Exphadis.Core.Contract.Mapper;

public class NoteProfile : Profile
{
    public NoteProfile()
    {
        this.CreateMap<Competence, CompetenceDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            ?.ForMember(dest => dest.IdLevel, opt => opt.MapFrom(src => src.IdLevel))
            ?.ForMember(dest => dest.IdArea, opt => opt.MapFrom(src => src.IdArea))
            ?.ForMember(dest => dest.Area, opt => opt.MapFrom(src => src.AreaName))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ForMember(dest => dest.Capacities, opt => opt.MapFrom(src => src.Capacities))
            ?.ReverseMap();

        this.CreateMap<CompetenceSelected, CompetenceForSubjectDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdCompetence))
            ?.ForMember(dest => dest.IdCompetenceSelected, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.Competence.Name}"))
            ?.ForMember(dest => dest.Transversal, opt => opt.MapFrom(src => $"{src.Competence.Transversal}"))
            ?.ForMember(dest => dest.IdArea, opt => opt.MapFrom(src => $"{src.Competence.IdArea}"));

        this.CreateMap<Criteria, CriteriaDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            ?.ForMember(dest => dest.Weight, opt => opt.MapFrom(src => src.Weight))
            ?.ForMember(dest => dest.CompetenceId, opt => opt.MapFrom(src => src.IdCompetence))
            ?.ForMember(dest => dest.SubjectId, opt => opt.MapFrom(src => src.IdAsignature))
            ?.ForMember(dest => dest.IdWorker, opt => opt.MapFrom(src => src.IdWorker))
            ?.ForMember(dest => dest.IdUnityConfiguration, opt => opt.MapFrom(src => src.IdUnityConfiguration))
            ?.ReverseMap();

        this.CreateMap<GradeEquivalenceConfigDto, GradeEquivalenceConfiguration>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
            ?.ForMember(dest => dest.LowerGrade, opt => opt.MapFrom(src => src.LowerGrade))
            ?.ForMember(dest => dest.UpperGrade, opt => opt.MapFrom(src => src.UpperGrade))
            ?.ForMember(dest => dest.IdLevel, opt => opt.MapFrom(src => src.IdLevel))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ReverseMap();

        this.CreateMap<CompetenceSelected, CompetenceSelectedDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.IdAsignature, opt => opt.MapFrom(src => src.IdSubject))
            ?.ForMember(dest => dest.IdCompetence, opt => opt.MapFrom(src => src.IdCompetence))
            ?.ForMember(dest => dest.IdUnity, opt => opt.MapFrom(src => src.IdUnity))
            ?.ForMember(dest => dest.IdWorker, opt => opt.MapFrom(src => src.IdWorker))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ReverseMap();

        this.CreateMap<GenericGradeDto, Conduct>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.IdStudent, opt => opt.MapFrom(src => src.StudentId))
            ?.ForMember(dest => dest.IdEnrollment, opt => opt.MapFrom(src => src.EnrollmentId))
            ?.ForMember(dest => dest.IdWorker, opt => opt.MapFrom(src => src.WorkerId))
            ?.ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value.ConvertObjectToDecimal()))
            ?.ForMember(dest => dest.Bimester, opt => opt.Ignore())
            ?.ForMember(dest => dest.IdUnity, opt => opt.MapFrom(src => src.UnityId))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ReverseMap();

        this.CreateMap<GenericGradeDto, AdditionalQualificationGrade>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value.ConvertObjectToDecimal()))
            ?.ForMember(dest => dest.IdStudent, opt => opt.MapFrom(src => src.StudentId))
            ?.ForMember(dest => dest.IdWorker, opt => opt.MapFrom(src => src.WorkerId))
            ?.ForMember(dest => dest.IdUnity, opt => opt.MapFrom(src => src.UnityId))
            ?.ForMember(dest => dest.IdGrade, opt => opt.MapFrom(src => src.GradeId))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ForMember(dest => dest.IdQualificationType, opt => opt.Ignore())
            ?.ReverseMap();

        this.CreateMap<AbilityGradeDto, CriteriaNote>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
            ?.ForMember(dest => dest.IdCriteria, opt => opt.MapFrom(src => src.CriteriaId))
            ?.ForMember(dest => dest.IdStudent, opt => opt.MapFrom(src => src.StudentId))
            ?.ForMember(dest => dest.IdWorker, opt => opt.MapFrom(src => src.WorkerId))
            ?.ForMember(dest => dest.IdUnity, opt => opt.MapFrom(src => src.UnityId))
            ?.ForMember(dest => dest.IdAsignature, opt => opt.MapFrom(src => src.SubjectId))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ReverseMap();

        this.CreateMap<UnityGradeDto, UnityGrade>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
            ?.ForMember(dest => dest.Score, opt => opt.MapFrom(src => src.Score))
            ?.ForMember(dest => dest.IdSubject, opt => opt.MapFrom(src => src.SubjectId))
            ?.ForMember(dest => dest.IdStudent, opt => opt.MapFrom(src => src.StudentId))
            ?.ForMember(dest => dest.IdWorker, opt => opt.MapFrom(src => src.WorkerId))
            ?.ForMember(dest => dest.IdUnity, opt => opt.MapFrom(src => src.UnityId))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ReverseMap();

        this.CreateMap<CompetenceGradeDto, CompetenceGrade>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
            ?.ForMember(dest => dest.IdCompetence, opt => opt.MapFrom(src => src.CompetenceId))
            ?.ForMember(dest => dest.IdStudent, opt => opt.MapFrom(src => src.StudentId))
            ?.ForMember(dest => dest.IdWorker, opt => opt.MapFrom(src => src.WorkerId))
            ?.ForMember(dest => dest.IdUnity, opt => opt.MapFrom(src => src.UnityId))
            ?.ForMember(dest => dest.IdSubject, opt => opt.MapFrom(src => src.SubjectId))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ReverseMap();

        this.CreateMap<AdditionalQualificationGrade, AdditionalQualificationDto>()
            ?.ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
            ?.ForMember(dest => dest.IdSubject, opt => opt.Ignore())
            ?.ForMember(dest => dest.IdCompetence, opt => opt.Ignore())
            ?.ForMember(dest => dest.IdArea, opt => opt.Ignore())
            ?.ForMember(dest => dest.IdStudent, opt => opt.MapFrom(src => src.IdStudent))
            ?.ForMember(dest => dest.IdWorker, opt => opt.MapFrom(src => src.IdWorker))
            ?.ForMember(dest => dest.IdUnity, opt => opt.MapFrom(src => src.IdUnity))
            ?.ForMember(dest => dest.IdGrade, opt => opt.MapFrom(src => src.IdGrade))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ForMember(dest => dest.IdQualificationType, opt => opt.MapFrom(src => src.IdQualificationType));
    }
}
