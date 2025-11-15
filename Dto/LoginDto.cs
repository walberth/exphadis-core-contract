namespace Exphadis.Core.Contract.Dto;

using Base;

public class LoginDto : AuditDto
{
    public int UserId { get; set; }

    public int PersonId { get; set; }

    public int WorkerId { get; set; }

    public string CompleteName { get; set; }

    public bool Sex { get; set; }

    public string Email { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public bool? Active { get; set; }

    public string Document { get; set; }

    public string Mobile { get; set; }

    public string Telephone { get; set; }

    public int Age { get; set; }

    public DateTime? BirthDate { get; set; }

    public SessionDto Session { get; set; }

    public AccessDto Access { get; set; }

    public GenericDto Position { get; set; }

    public string Token { get; set; }

    public DateTime Expires { get; set; }

    public string ImageUrl { get; set; }

    public bool? HaveActiveContract { get; set; }

    public int PersonAge()
    {
        if (this.BirthDate != null)
        {
            return (int)Math.Floor(DateTime.Now.Subtract((DateTime)this.BirthDate).TotalDays / 365);
        }

        return 0;
    }
}

public class UserLoginDto
{
    // [Required(ErrorMessage = "Es necesario indicar el usuario")]
    public string Username { get; set; }

    // [Required(ErrorMessage = "Es necesario indicar la contraseña")]
    public string Password { get; set; }

    public string Email { get; set; }

    public string CompleteName { get; set; }

    public string Ip { get; set; }

    public string ApplicationClient { get; set; }

    public string Key { get; set; }
}
