namespace Exphadis.Core.Contract.Dto;

public class RadicaleContactsExportResultDto
{
    public string CollectionPath { get; set; }

    public int TotalContacts { get; set; }

    public string ExportFilePath { get; set; }

    public DateTime GeneratedAt { get; set; }
}