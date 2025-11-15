// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Mapper;

public class MasterDataProfile : Profile
{
    public MasterDataProfile()
    {
        this.CreateMap<PaymentType, PaymentTypeDto>()
            ?.ReverseMap();

        this.CreateMap<PersonType, PersonTypeDto>()
            ?.ReverseMap();

        this.CreateMap<Document, DocumentTypeDto>()
            ?.ReverseMap();

        this.CreateMap<Department, DepartmentDto>()
            ?.ReverseMap();

        this.CreateMap<Province, ProvinceDto>()
            ?.ReverseMap();

        this.CreateMap<District, DistrictDto>()
            ?.ReverseMap();

        this.CreateMap<GradeInstruction, GradeInstructionTypeDto>()
            ?.ReverseMap();

        this.CreateMap<RelationshipType, RelationshipTypeDto>()
            ?.ReverseMap();

        this.CreateMap<ReferenceType, ReferenceTypeDto>()
            ?.ReverseMap();

        this.CreateMap<Level, LevelDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ReverseMap();

        this.CreateMap<Grade, GradeDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.IdLevel, opt => opt.MapFrom(src => src.IdLevel))
            ?.ReverseMap();

        this.CreateMap<Section, SectionDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ReverseMap();

        this.CreateMap<Turn, TurnDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ReverseMap();

        this.CreateMap<PaymentType, PaymentTypeDto>()
            ?.ReverseMap();

        this.CreateMap<PeriodicityType, PeriodicityTypeDto>()
            ?.ReverseMap();

        this.CreateMap<PositionType, PositionTypeDto>()
            ?.ReverseMap();

        this.CreateMap<MoneyMovementType, MoneyMovementTypeDto>()
            ?.ReverseMap();

        this.CreateMap<BankType, BankTypeDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Active, opt => opt.MapFrom(src => src.Active))
            ?.ReverseMap();

        this.CreateMap<UnityConfigurationShow, UnityConfigurationShowDto>()
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
            ?.ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
            ?.ForMember(dest => dest.UnityIdentifiers, opt => opt.MapFrom(src => src.UnityIdentifiers))
            ?.ReverseMap();

        this.CreateMap<Unity, UnityConfigurationDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.UnityName, opt => opt.MapFrom(src => src.UnityName))
            ?.ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
            ?.ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
            ?.ForMember(dest => dest.BimesterBelong, opt => opt.MapFrom(src => src.BimesterBelong))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ForMember(dest => dest.UserRegister, opt => opt.MapFrom(src => src.UserRegister))
            ?.ForMember(dest => dest.UserUpdated, opt => opt.MapFrom(src => src.UserUpdated))
            ?.ForMember(dest => dest.TimeRegister, opt => opt.MapFrom(src => src.TimeRegister))
            ?.ForMember(dest => dest.TimeUpdated, opt => opt.MapFrom(src => src.TimeUpdated))
            ?.ReverseMap();

        this.CreateMap<Ability, GenericDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Description, opt => opt.Ignore())
            ?.ReverseMap();

        this.CreateMap<Unity, GenericDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.UnityName))
            ?.ForMember(dest => dest.Description, opt => opt.Ignore())
            ?.ReverseMap();

        this.CreateMap<CustomerDto, Customer>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Number))
            ?.ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            ?.ForMember(dest => dest.Document, opt => opt.MapFrom(src => src.Document))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ForMember(dest => dest.Stages, opt => opt.Ignore());

        this.CreateMap<Customer, CustomerDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Number))
            ?.ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            ?.ForMember(dest => dest.Document, opt => opt.MapFrom(src => src.Document))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ForMember(dest => dest.Stages, opt => opt.MapFrom(src => src.Stages))
            ?.ForMember(dest => dest.LastStage, opt => opt.Ignore());

        this.CreateMap<CustomerStageDto, CustomerStage>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
            ?.ForMember(dest => dest.WorkerId, opt => opt.MapFrom(src => src.WorkerId))
            ?.ForMember(dest => dest.StageId, opt => opt.MapFrom(src => $"{(int)src.Stage}"))
            ?.ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
            ?.ForMember(dest => dest.NumberKids, opt => opt.MapFrom(src => src.NumberKids))
            ?.ForMember(dest => dest.DateEnrollment, opt => opt.MapFrom(src => src.DateEnrollment))
            ?.ForMember(dest => dest.AmountPayment, opt => opt.MapFrom(src => src.AmountPayment))
            ?.ForMember(dest => dest.DateRegister, opt => opt.MapFrom(src => src.DateRegister))
            ?.ForMember(dest => dest.Customer, opt => opt.Ignore())
            ?.ForMember(dest => dest.Stage, opt => opt.Ignore())
            ?.ForMember(dest => dest.Worker, opt => opt.Ignore());

        this.CreateMap<CustomerStage, CustomerStageDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
            ?.ForMember(dest => dest.WorkerId, opt => opt.MapFrom(src => src.WorkerId))
            ?.ForMember(dest => dest.WorkerName, opt => opt.MapFrom(src => $"{src.Worker.Person.CompleteName}"))
            ?.ForMember(dest => dest.Stage, opt => opt.MapFrom(src => $"{(InformStageEnum)src.StageId}"))
            ?.ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
            ?.ForMember(dest => dest.NumberKids, opt => opt.MapFrom(src => src.NumberKids))
            ?.ForMember(dest => dest.DateEnrollment, opt => opt.MapFrom(src => src.DateEnrollment))
            ?.ForMember(dest => dest.AmountPayment, opt => opt.MapFrom(src => src.AmountPayment))
            ?.ForMember(dest => dest.DateRegister, opt => opt.MapFrom(src => src.DateRegister))
            ?.ForMember(dest => dest.StageName, opt => opt.Ignore());

        this.CreateMap<InformStage, InformStageDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.Order));

        this.CreateMap<PsychologyAppointmentDto, PsychologyAppointment>()
            ?.ReverseMap();

        this.CreateMap<MediaType, GenericDto>()
            ?.ReverseMap();

        this.CreateMap<MediaOption, MediaOptionDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))
            ?.ForMember(dest => dest.MediaId, opt => opt.MapFrom(src => src.MediaId))
            ?.ForMember(dest => dest.MediaTypeId, opt => opt.MapFrom(src => src.MediaTypeId))
            ?.ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.Order))
            ?.ForMember(dest => dest.MediaType, opt => opt.MapFrom(src => $"{src.MediaType.Name}"));

        this.CreateMap<MediaOptionDto, MediaOption>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))
            ?.ForMember(dest => dest.MediaId, opt => opt.MapFrom(src => src.MediaId))
            ?.ForMember(dest => dest.MediaTypeId, opt => opt.MapFrom(src => src.MediaTypeId))
            ?.ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.Order))
            ?.ForMember(dest => dest.MediaType, opt => opt.Ignore())
            ?.ForMember(dest => dest.Media, opt => opt.Ignore());

        this.CreateMap<EmailTemplate, GenericDto>()
            ?.ReverseMap();

        this.CreateMap<PaymentCommitmentStatus, GenericDto>()
            ?.ReverseMap();

        this.CreateMap<AssistanceJustificationType, GenericDto>()
            ?.ReverseMap();

        this.CreateMap<EmailSend, EmailDto>()
            ?.ForMember(dest => (int)dest.EmailTemplate, opt => opt.MapFrom(src => src.IdEmailTemplate))
            ?.ForMember(dest => dest.Attachments, opt => opt.Ignore())
            ?.ForMember(dest => dest.Parameters, opt => opt.Ignore());

        this.CreateMap<EmailDto, EmailSend>()
            ?.ForMember(dest => dest.Id, opt => opt.Ignore())
            ?.ForMember(dest => dest.Subject, opt => opt.MapFrom(src => src.Subject))
            ?.ForMember(dest => dest.From, opt => opt.Ignore())
            ?.ForMember(dest => dest.To, opt => opt.MapFrom(src => src.To))
            ?.ForMember(dest => dest.Cc, opt => opt.MapFrom(src => src.Cc))
            ?.ForMember(dest => dest.Bcc, opt => opt.Ignore())
            ?.ForMember(dest => dest.IdEmailTemplate, opt => opt.MapFrom(src => (int)src.EmailTemplate))
            ?.ForMember(dest => dest.UserRegister, opt => opt.MapFrom(src => src.UserRegister))
            ?.ForMember(dest => dest.TimeRegister, opt => opt.MapFrom(src => src.TimeRegister))
            ?.ForMember(dest => dest.EmailTemplate, opt => opt.Ignore())
            ?.ForMember(dest => dest.Attachments, opt => opt.Ignore());

        this.CreateMap<Announcement, AnnouncementDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Body, opt => opt.MapFrom(src => src.Body))
            .ForMember(dest => dest.DateToPublish, opt => opt.MapFrom(src => src.DateToPublish))
            .ForMember(dest => dest.MediaId, opt => opt.MapFrom(src => src.MediaId))
            .ForMember(dest => dest.RoleIds, opt => opt.Ignore())
            .ForMember(dest => dest.Roles, opt => opt.Ignore())
            .ForMember(dest => dest.FilesNumber, opt => opt.Ignore())
            .ForMember(dest => dest.LevelId, opt => opt.Ignore())
            .ForMember(dest => dest.GradeIds, opt => opt.Ignore());

        this.CreateMap<AnnouncementDto, Announcement>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Body, opt => opt.MapFrom(src => src.Body))
            .ForMember(dest => dest.DateToPublish, opt => opt.MapFrom(src => src.DateToPublish))
            .ForMember(dest => dest.MediaId, opt => opt.MapFrom(src => src.MediaId))
            .ForMember(dest => dest.RoleIds, opt => opt.MapFrom(src => $"{src.RoleIds.ToList().ConvertToIntListString()}"))
            .ForMember(dest => dest.LevelId, opt => opt.MapFrom(src => $"{(src.LevelId != 0 ? src.LevelId.ConvertObjectToString() : string.Empty)}"))
            .ForMember(dest => dest.GradeIds, opt => opt.MapFrom(src => $"{src.GradeIds.ToList().ConvertToIntListString()}"))
            .ForMember(dest => dest.Media, opt => opt.Ignore());

        this.CreateMap<LogDto, Core.Domain.MasterDataAggregates.Log>()
            ?.ForMember(dest => dest.Id, opt => opt.Ignore())
            ?.ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.Message))
            ?.ForMember(dest => dest.MessageTemplate, opt => opt.Ignore())
            ?.ForMember(dest => dest.Level, opt => opt.MapFrom(src => $"{src.Level.GetEnumMemberValue()}"))
            ?.ForMember(dest => dest.TimeStamp, opt => opt.MapFrom(src => src.TimeStamp))
            ?.ForMember(dest => dest.Exception, opt => opt.MapFrom(src => src.Stack))
            ?.ForMember(dest => dest.Properties, opt => opt.Ignore())
            ?.ForMember(dest => dest.TraceIdentifier, opt => opt.MapFrom(src => $"{src.TraceIdentifier.ToString()}"))
            ?.ForMember(dest => dest.QueryString, opt => opt.Ignore())
            ?.ForMember(dest => dest.RequestBody, opt => opt.Ignore())
            ?.ForMember(dest => dest.RouteParams, opt => opt.Ignore())
            ?.ForMember(dest => dest.AppName, opt => opt.MapFrom(src => src.AppName));

        this.CreateMap<SupplierDto, Supplier>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
            ?.ForMember(dest => dest.Type, opt => opt.MapFrom(src => $"{src.Type.GetEnumMemberValue()}"))
            ?.ForMember(dest => dest.ReceiptIssued, opt => opt.MapFrom(src => $"{src.ReceiptIssued.GetEnumMemberValue()}"))
            ?.ForMember(dest => dest.Mobile, opt => opt.MapFrom(src => src.Mobile))
            ?.ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            ?.ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Comments));

        this.CreateMap<Supplier, SupplierDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            ?.ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
            ?.ForMember(dest => dest.Type, opt => opt.MapFrom(src => $"{src.Type.TryParseEnum<PersonTypeEnum>()}"))
            ?.ForMember(dest => dest.ReceiptIssued, opt => opt.MapFrom(src => $"{src.ReceiptIssued.TryParseEnum<EgressInvoiceTypeEnum>()}"))
            ?.ForMember(dest => dest.Mobile, opt => opt.MapFrom(src => src.Mobile))
            ?.ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            ?.ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Comments));
    }
}
