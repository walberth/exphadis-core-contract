namespace Exphadis.Core.Contract.Dto;

public class RadicalePendingPensionSyncResultDto
{
    public DateTime ExecutionDate { get; set; }

    public string TargetMonth { get; set; }

    public int TargetMonthNumber { get; set; }

    public int TargetYear { get; set; }

    public string CollectionPath { get; set; }

    public int EvaluatedEnrollments { get; set; }

    public int ApplicableEnrollments { get; set; }

    public int DebtorStudents { get; set; }

    public int DebtorAttorneys { get; set; }

    public int ContactsUpserted { get; set; }

    public int ContactsDeleted { get; set; }

    public int ContactsSkippedWithoutPhone { get; set; }

    public int ContactsSkippedBecausePhoneAlreadyExists { get; set; }

    public List<string> UpsertedContactPaths { get; set; } = new();

    public List<string> DeletedContactPaths { get; set; } = new();
}