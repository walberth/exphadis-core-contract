namespace Exphadis.Core.Contract.Dto;

using Base;

public class UserDto : AuditDto
{
    public int Id { get; set; }

    public int IdPerson { get; set; }

    public string Username { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public bool Active { get; set; }

    public IEnumerable<int> Roles { get; set; } = new HashSet<int>();

    public IEnumerable<RoleDto> RoleList { get; set; } = new HashSet<RoleDto>();

    public string CompleteName { get; set; } = string.Empty;

    public string State => this.Active ? "ACTIVO" : "INACTIVO";

    public string RoleNames =>
        this.RoleList.Any()
            ? string.Join(", ", this.RoleList.Select(x => x.Name).ToList()!)
            : null;
}

public class UserRoleDto
{
    public int Id { get; set; }

    public int IdRole { get; set; }

    public int IdUser { get; set; }
}
