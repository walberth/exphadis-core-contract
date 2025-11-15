namespace Exphadis.Core.Contract.Dto;

using Base;

public class WorkshopConfigurationDto : AuditDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int NumberSessions { get; set; }

    public int IdWorker { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime InscriptionEndDate { get; set; }

    public int MinQuota { get; set; }

    public int MaxQuota { get; set; }

    public string StartHour { get; set; }

    public string EndHour { get; set; }

    public bool Active { get; set; }

    public IEnumerable<string> WeekDays { get; set; } = new HashSet<string>();
}

public class WorkshopInscriptionDto : AuditDto
{
    public int Id { get; set; }

    public int IdWorkshop { get; set; }

    public int IdWorker { get; set; }

    public int IdStudent { get; set; }

    public bool Active { get; set; }

    public DateTime InscriptionDate { get; set; }
}

public class WorkshopResultDto : AuditDto
{
    public int Id { get; set; }

    public int IdWorkshopInscription { get; set; }

    public int IdStudent { get; set; }

    public int IdWorker { get; set; }

    public int IdWorkshopState { get; set; }

    public string Comment { get; set; }

    public decimal FinalGrade { get; set; }
}
