namespace Exphadis.Core.Contract.Dto;

public class SessionDto
{
    public string ExpirationHours { get; set; }

    public int UserId { get; set; }

    public DateTime? SessionExpirationTime { get; set; }
}
