namespace Exphadis.Core.Contract.Dto;

using Base;

using Enums;

public class ContractDto : AuditDto
{
    public int Id { get; set; }

    public ContractTypeEnum ContractType { get; set; }

    public DateTime? PeriodicityStart { get; set; }

    public DateTime? PeriodicityEnd { get; set; }

    public ContributionTypeEnum ContributionType { get; set; }

    public AfpTypeEnum AfpType { get; set; }

    public EssaludTypeEnum EssaludType { get; set; }

    public string EssaludSisCode { get; set; }

    public bool? HaveKids { get; set; }

    public int? MediaId { get; set; }

    public int WorkerId { get; set; }

    public IEnumerable<int> PositionIds { get; set; }

    public decimal? BasicSalaryAmount { get; set; } // 1

    public decimal? FamilyAssignmentAmount { get; set; } // 2

    public decimal? BruteSalaryAmount { get; set; } // 3

    public decimal? PensionContributionAmount { get; set; } // 4

    public decimal? HealthContributionAmount { get; set; } // 5

    public decimal? NetSalaryAmount { get; set; } // 6

    public decimal? BonusAmount { get; set; } // 7

    public decimal? NetRemunerationAmount { get; set; } // 8

    public decimal LiquidSalaryAmount { get; set; } // 9

    public decimal TotalAmount { get; set; } // 10

    public int? VacationDays { get; set; }

    public int Year { get; set; }

    public string Comment { get; set; }

    public bool Active { get; set; }

    public string ContributionTypeName => this.ContributionType.GetEnumMemberValue();

    public string ContractTypeName => this.ContractType.GetEnumMemberValue();

    public string AfpTypeName => this.AfpType.GetEnumMemberValue();

    public string EssaludTypeName => this.EssaludType.GetEnumMemberValue();

    public string CompleteName => this.Worker?.Person?.CompleteName;

    public IEnumerable<PositionTypeDto> Positions { get; set; } = new HashSet<PositionTypeDto>();

    public string PositionNames =>
        this.Positions.Any()
            ? string.Join(", ", this.Positions.Select(x => x.Name).ToList())
            : null;

    public WorkerDto Worker { get; set; }
}

public class TicketDto
{
    [Required]
    public int Month { get; set; }

    [Required]
    public int Year { get; set; }

    public string Data { get; set; }

    public string FileName { get; set; }

    [Required]
    public string UserUploaded { get; set; }

    [Required]
    public DateTime DateUploaded { get; set; }

    public int Id { get; set; }

    public int WorkerId { get; set; }

    public string WorkerName { get; set; }

    public string MonthName { get; set; }

    public string Url { get; set; }

    public IEnumerable<int> PositionIds { get; set; }

    public string ContractType { get; set; }

    public IEnumerable<PositionTypeDto> Positions { get; set; } = new HashSet<PositionTypeDto>();

    public string PositionNames =>
        this.Positions.Any()
            ? string.Join(", ", this.Positions.Select(x => x.Name).ToList())
            : null;
}
