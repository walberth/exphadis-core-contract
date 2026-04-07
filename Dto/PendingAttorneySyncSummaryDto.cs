namespace Exphadis.Core.Contract.Dto;

public class PendingAttorneySyncSummaryDto
{
    public int DebtorStudents { get; set; }

    public int DebtorAttorneys { get; set; }

    public int ContactsUpserted { get; set; }

    public int ContactsDeleted { get; set; }

    public int ContactsSkippedWithoutPhone { get; set; }

    public int ContactsSkippedBecausePhoneAlreadyExists { get; set; }

    public List<string> UpsertedContactPaths { get; set; } = new();

    public List<string> DeletedContactPaths { get; set; } = new();
}