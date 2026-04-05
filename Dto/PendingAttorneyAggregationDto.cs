namespace Exphadis.Core.Contract.Dto;

public class PendingAttorneyAggregationDto
{
    public int AttorneyId { get; set; }

    public int PersonId { get; set; }

    public string AttorneyFirstName { get; set; }

    public string AttorneyFatherLastName { get; set; }

    public List<string> SourcePhones { get; set; } = new();

    public Dictionary<int, PendingStudentSummaryDto> Students { get; set; } = new();
}