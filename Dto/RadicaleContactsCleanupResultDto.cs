namespace Exphadis.Core.Contract.Dto;

public class RadicaleContactsCleanupResultDto
{
    public string CollectionPath { get; set; }

    public int TotalContacts { get; set; }

    public int ContactsDeleted { get; set; }

    public int ContactsPreserved { get; set; }

    public List<string> DeletedContactPaths { get; set; } = new();

    public List<string> PreservedContactPaths { get; set; } = new();
}