namespace Exphadis.Core.Contract.Dto;

public class UnityConfigurationDto
{
    public int Id { get; set; }

    public string UnityName { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int BimesterBelong { get; set; }

    public int Year { get; set; }

    public string UserRegister { get; set; }

    public string UserUpdated { get; set; }

    public DateTime? TimeRegister { get; set; }

    public DateTime? TimeUpdated { get; set; }
}
