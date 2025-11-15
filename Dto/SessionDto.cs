namespace Exphadis.Core.Contract.Dto;

public class SessionDto
{
    public string ExpirationHours { get; set; }

    public string IdSession { get; set; }

    public int IdUser { get; set; }

    public DateTime? SessionExpirationTime { get; set; }
}
