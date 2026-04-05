namespace Exphadis.Core.Contract.Dto;

public class PendingAttorneyContactDto
{
    public int AttorneyId { get; set; }

    public int PersonId { get; set; }

    public List<string> SourcePhones { get; set; }

    public string Phone { get; set; }

    public string ContactName { get; set; }

    public string Note { get; set; }

    public string TargetMonth { get; set; }

    public int TargetYear { get; set; }

    public int DebtorStudents { get; set; }

    public string SummaryGradeLevelLabel { get; set; }

    public bool ShouldSkip { get; set; }
}