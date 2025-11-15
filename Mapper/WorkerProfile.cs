// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Mapper;

public class WorkerProfile : Profile
{
    public WorkerProfile()
    {
        this.CreateMap<Worker, WorkerDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.AssistanceId, opt => opt.MapFrom(src => src.AssistanceId))
            ?.ForMember(dest => dest.IdGradeInstructionType, opt => opt.MapFrom(src => src.IdGradeInstructionType))
            ?.ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
            ?.ForMember(dest => dest.Active, opt => opt.MapFrom(src => src.Active))
            ?.ForMember(dest => dest.IdBank, opt => opt.MapFrom(src => src.IdBank))
            ?.ForMember(dest => dest.AccountNumber, opt => opt.MapFrom(src => src.AccountNumber))
            ?.ForMember(dest => dest.InterbankAccountNumber, opt => opt.MapFrom(src => src.InterBankAccountNumber))
            ?.ForMember(dest => dest.Person, opt => opt.MapFrom(src => src.Person))
            ?.ForMember(dest => dest.Fingerprint, opt => opt.MapFrom(src => src.Fingerprint))
            ?.ForMember(dest => dest.CurriculumUrl, opt => opt.MapFrom(src => src.CurriculumUrl))
            ?.ForMember(dest => dest.IdPositions, opt => opt.Ignore())
            ?.ForMember(dest => dest.Contract, opt => opt.Ignore())
            ?.ForMember(dest => dest.Positions, opt => opt.Ignore())
            ?.ForMember(dest => dest.Mobile, opt => opt.Ignore())
            ?.ForMember(dest => dest.Email, opt => opt.Ignore())
            ?.ForMember(dest => dest.CompleteName, opt => opt.Ignore())
            ?.ForMember(dest => dest.LastContractYear, opt => opt.Ignore())
            ?.ForMember(dest => dest.LastContractPosition, opt => opt.Ignore())
            ?.ForMember(dest => dest.State, opt => opt.Ignore())
            ?.ForMember(dest => dest.Roles, opt => opt.Ignore())
            ?.ForMember(dest => dest.PositionList, opt => opt.Ignore())
            ?.ForMember(dest => dest.PositionNames, opt => opt.Ignore())
            ?.ForMember(dest => dest.RoleNames, opt => opt.Ignore());

        this.CreateMap<WorkerDto, Worker>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.AssistanceId, opt => opt.MapFrom(src => src.AssistanceId))
            ?.ForMember(dest => dest.IdPerson, opt => opt.MapFrom(src => $"{src.Person.Id}"))
            ?.ForMember(dest => dest.IdGradeInstructionType, opt => opt.MapFrom(src => src.IdGradeInstructionType))
            ?.ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
            ?.ForMember(dest => dest.Active, opt => opt.MapFrom(src => src.Active))
            ?.ForMember(dest => dest.IdBank, opt => opt.MapFrom(src => src.IdBank))
            ?.ForMember(dest => dest.AccountNumber, opt => opt.MapFrom(src => src.AccountNumber))
            ?.ForMember(dest => dest.InterBankAccountNumber, opt => opt.MapFrom(src => src.InterbankAccountNumber))
            ?.ForMember(dest => dest.Fingerprint, opt => opt.MapFrom(src => src.Fingerprint))
            ?.ForMember(dest => dest.CurriculumUrl, opt => opt.MapFrom(src => src.CurriculumUrl))
            ?.ForMember(dest => dest.Person, opt => opt.Ignore())
            ?.ForMember(dest => dest.Subject, opt => opt.Ignore())
            ?.ForMember(dest => dest.Criteria, opt => opt.Ignore())
            ?.ForMember(dest => dest.Tutorship, opt => opt.Ignore())
            ?.ForMember(dest => dest.Assistance, opt => opt.Ignore())
            ?.ForMember(dest => dest.WorkerPayment, opt => opt.Ignore())
            ?.ForMember(dest => dest.WorkshopResult, opt => opt.Ignore())
            ?.ForMember(dest => dest.Contracts, opt => opt.Ignore())
            ?.ForMember(dest => dest.WorkshopInscription, opt => opt.Ignore())
            ?.ForMember(dest => dest.WorkshopConfiguration, opt => opt.Ignore())
            ?.ForMember(dest => dest.PsychologyAppointment, opt => opt.Ignore())
            ?.ForMember(dest => dest.PotentialCustomerStage, opt => opt.Ignore())
            ?.ForMember(dest => dest.AssistanceJustification, opt => opt.Ignore())
            ?.ForMember(dest => dest.Subjects, opt => opt.Ignore())
            ?.ForMember(dest => dest.AdditionalQualifications, opt => opt.Ignore())
            ?.ForMember(dest => dest.WorkerAssists, opt => opt.Ignore())
            ?.ForMember(dest => dest.WorkerAssistanceJustifications, opt => opt.Ignore())
            ?.ForMember(dest => dest.Conduct, opt => opt.Ignore());

        this.CreateMap<WorkerPayment, WorkerPaymentDto>()
            ?.ReverseMap();

        this.CreateMap<WorkerDiscount, WorkerDiscountDto>()
            ?.ReverseMap();

        this.CreateMap<Domain.WorkerAggregates.Contract, ContractDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.ContractType, opt => opt.MapFrom(src => $"{src.ContractType.TryParseEnum<ContractTypeEnum>()}"))
            ?.ForMember(dest => dest.PeriodicityStart, opt => opt.MapFrom(src => src.PeriodicityStart))
            ?.ForMember(dest => dest.PeriodicityEnd, opt => opt.MapFrom(src => src.PeriodicityEnd))
            ?.ForMember(dest => dest.ContributionType, opt => opt.MapFrom(src => $"{src.ContributionType.TryParseEnum<ContributionTypeEnum>()}"))
            ?.ForMember(dest => dest.EssaludType, opt => opt.MapFrom(src => $"{src.EssaludType.TryParseEnum<EssaludTypeEnum>()}"))
            ?.ForMember(dest => dest.EssaludSisCode, opt => opt.MapFrom(src => src.EssaludSisCode))
            ?.ForMember(dest => dest.HaveKids, opt => opt.MapFrom(src => src.HaveKids))
            ?.ForMember(dest => dest.MediaId, opt => opt.MapFrom(src => src.MediaId))
            ?.ForMember(dest => dest.WorkerId, opt => opt.MapFrom(src => src.WorkerId))
            ?.ForMember(dest => dest.PositionIds, opt => opt.Ignore())

            // ?.ForMember(dest => dest.PositionIds, opt => opt.MapFrom(src => $"{src.Positions.ConvertStringToIntList().ToList()}"))
            ?.ForMember(dest => dest.BasicSalaryAmount, opt => opt.MapFrom(src => src.BasicSalaryAmount)) // 1
            ?.ForMember(dest => dest.FamilyAssignmentAmount, opt => opt.MapFrom(src => src.FamilyAssignmentAmount)) // 2
            ?.ForMember(dest => dest.BruteSalaryAmount, opt => opt.MapFrom(src => src.BruteSalaryAmount)) // 3
            ?.ForMember(dest => dest.PensionContributionAmount, opt => opt.MapFrom(src => src.PensionContributionAmount)) // 4
            ?.ForMember(dest => dest.HealthContributionAmount, opt => opt.MapFrom(src => src.HealthContributionAmount)) // 5
            ?.ForMember(dest => dest.NetSalaryAmount, opt => opt.MapFrom(src => src.NetSalaryAmount)) // 6
            ?.ForMember(dest => dest.BonusAmount, opt => opt.MapFrom(src => src.BonusAmount)) // 7
            ?.ForMember(dest => dest.NetRemunerationAmount, opt => opt.MapFrom(src => src.NetRemunerationAmount)) // 8
            ?.ForMember(dest => dest.LiquidSalaryAmount, opt => opt.MapFrom(src => src.LiquidSalaryAmount)) // 9
            ?.ForMember(dest => dest.TotalAmount, opt => opt.MapFrom(src => src.TotalAmount)) // 10

            ?.ForMember(dest => dest.VacationDays, opt => opt.MapFrom(src => src.Vacation))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
            ?.ForMember(dest => dest.Active, opt => opt.MapFrom(src => src.Active))
            ?.ForMember(dest => dest.Worker, opt => opt.MapFrom(src => src.Worker))

            ?.ForMember(dest => dest.ContributionTypeName, opt => opt.Ignore())
            ?.ForMember(dest => dest.ContractTypeName, opt => opt.Ignore())
            ?.ForMember(dest => dest.CompleteName, opt => opt.Ignore())
            ?.ForMember(dest => dest.Positions, opt => opt.Ignore())
            ?.ForMember(dest => dest.PositionNames, opt => opt.Ignore());

        this.CreateMap<ContractDto, Domain.WorkerAggregates.Contract>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.ContractType, opt => opt.MapFrom(src => $"{src.ContractType.GetEnumMemberValue()}"))
            ?.ForMember(dest => dest.PeriodicityStart, opt => opt.MapFrom(src => src.PeriodicityStart))
            ?.ForMember(dest => dest.PeriodicityEnd, opt => opt.MapFrom(src => src.PeriodicityEnd))
            ?.ForMember(dest => dest.ContributionType, opt => opt.MapFrom(src => $"{src.ContributionType.GetEnumMemberValue()}"))
            ?.ForMember(dest => dest.EssaludType, opt => opt.MapFrom(src => $"{src.EssaludType.GetEnumMemberValue()}"))
            ?.ForMember(dest => dest.EssaludSisCode, opt => opt.MapFrom(src => src.EssaludSisCode))
            ?.ForMember(dest => dest.HaveKids, opt => opt.MapFrom(src => src.HaveKids))
            ?.ForMember(dest => dest.MediaId, opt => opt.MapFrom(src => src.MediaId))
            ?.ForMember(dest => dest.WorkerId, opt => opt.MapFrom(src => src.WorkerId))
            ?.ForMember(dest => dest.Positions, opt => opt.MapFrom(src => $"{string.Join(",", src.PositionIds)}"))

            ?.ForMember(dest => dest.BasicSalaryAmount, opt => opt.MapFrom(src => src.BasicSalaryAmount)) // 1
            ?.ForMember(dest => dest.FamilyAssignmentAmount, opt => opt.MapFrom(src => src.FamilyAssignmentAmount)) // 2
            ?.ForMember(dest => dest.BruteSalaryAmount, opt => opt.MapFrom(src => src.BruteSalaryAmount)) // 3
            ?.ForMember(dest => dest.PensionContributionAmount, opt => opt.MapFrom(src => src.PensionContributionAmount)) // 4
            ?.ForMember(dest => dest.HealthContributionAmount, opt => opt.MapFrom(src => src.HealthContributionAmount)) // 5
            ?.ForMember(dest => dest.NetSalaryAmount, opt => opt.MapFrom(src => src.NetSalaryAmount)) // 6
            ?.ForMember(dest => dest.BonusAmount, opt => opt.MapFrom(src => src.BonusAmount)) // 7
            ?.ForMember(dest => dest.NetRemunerationAmount, opt => opt.MapFrom(src => src.NetRemunerationAmount)) // 8
            ?.ForMember(dest => dest.LiquidSalaryAmount, opt => opt.MapFrom(src => src.LiquidSalaryAmount)) // 9
            ?.ForMember(dest => dest.TotalAmount, opt => opt.MapFrom(src => src.TotalAmount)) // 10

            ?.ForMember(dest => dest.Vacation, opt => opt.MapFrom(src => src.VacationDays))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
            ?.ForMember(dest => dest.Active, opt => opt.MapFrom(src => src.Active))

            ?.ForMember(dest => dest.PersonId, opt => opt.Ignore())
            ?.ForMember(dest => dest.CompleteName, opt => opt.Ignore())
            ?.ForMember(dest => dest.GradeInstructionTypeId, opt => opt.Ignore())
            ?.ForMember(dest => dest.GradeInstructionType, opt => opt.Ignore())
            ?.ForMember(dest => dest.PositionTypeId, opt => opt.Ignore())
            ?.ForMember(dest => dest.PositionType, opt => opt.Ignore())
            ?.ForMember(dest => dest.WorkerPayment, opt => opt.Ignore())
            ?.ForMember(dest => dest.Worker, opt => opt.Ignore())
            ?.ForMember(dest => dest.Media, opt => opt.Ignore());

        this.CreateMap<WorkerEvaluation, WorkerEvaluationDto>()
            ?.ForMember(dest => dest.IdState, opt => opt.MapFrom(src => src.IdEvaluationState))
            ?.ForMember(dest => dest.EvaluationResponses, opt => opt.Ignore())
            ?.ReverseMap();

        this.CreateMap<WorkerEvaluationResponse, WorkerEvaluationResponseDto>()
            ?.ReverseMap();

        this.CreateMap<Ticket, TicketDto>()
            ?.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            ?.ForMember(dest => dest.WorkerName, opt => opt.MapFrom(src => $"{src.Worker.Person.CompleteName}"))
            ?.ForMember(dest => dest.FileName, opt => opt.MapFrom(src => src.FileName))
            ?.ForMember(dest => dest.MonthName, opt => opt.MapFrom(src => src.MonthName))
            ?.ForMember(dest => dest.ContractType, opt => opt.MapFrom(src => $"{src.Contract.ContractType}"))
            ?.ForMember(dest => dest.Url, opt => opt.MapFrom(src => $"{Constant.UrlValidate}/api/worker/download/{src.Identifier}/ticket"))
            ?.ForMember(dest => dest.Month, opt => opt.MapFrom(src => src.Month))
            ?.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
            ?.ForMember(dest => dest.UserUploaded, opt => opt.MapFrom(src => src.UserUploaded))
            ?.ForMember(dest => dest.DateUploaded, opt => opt.MapFrom(src => src.DateUploaded))
            ?.ForMember(dest => dest.PositionIds, opt => opt.Ignore());
    }
}
