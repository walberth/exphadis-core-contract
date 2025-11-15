namespace Exphadis.Core.Contract.Dto;

public class MediaOptionDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public Uri Url { get; set; }

    public int MediaId { get; set; }

    public int MediaTypeId { get; set; }

    public string MediaType { get; set; }

    public int Order { get; set; }
}
