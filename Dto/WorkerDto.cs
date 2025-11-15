namespace Exphadis.Core.Contract.Dto;

using Base;

public class WorkerDto : AuditDto
{
    public int Id { get; set; }

    public int AssistanceId { get; set; }

    public int IdGradeInstructionType { get; set; }

    public string Comment { get; set; }

    public bool Active { get; set; }

    public int IdBank { get; set; }

    public string AccountNumber { get; set; }

    public string InterbankAccountNumber { get; set; }

    public PersonDto Person { get; set; }

    public List<int> IdPositions { get; set; }

    public ContractDto Contract { get; set; } // The last contract

    public string Fingerprint { get; set; }

    public string CurriculumUrl { get; set; }

    public IEnumerable<PositionTypeDto> Positions { get; set; } = new HashSet<PositionTypeDto>();

    public string Mobile => this.Person.Mobile;

    public string Email => this.Person.Email;

    public string CompleteName => this.Person.CompleteName;

    public int? LastContractYear => this.Contract?.Year;

    public string LastContractPosition =>
        this.Positions.Any()
            ? string.Join(", ", this.Positions.Select(x => x.Name).ToList())
            : null;

    public bool State => this.Person.User?.Active ?? false;

    public IEnumerable<RoleDto> Roles => this.Person.User?.RoleList;

    public IEnumerable<int> PositionList => this.Positions.Any() ? this.Positions?.Select(x => x.Id).ToList() : null;

    public string PositionNames =>
        this.Positions.Any()
            ? string.Join(", ", this.Positions.Select(x => x.Name).ToList())
            : null;

    public string RoleNames =>
        this.Person.User != null && this.Person.User.RoleList.Any()
            ? string.Join(", ", this.Person.User?.RoleList.Select(x => x.Name).ToList() !)
            : null;
}
