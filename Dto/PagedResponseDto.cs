namespace Exphadis.Core.Contract.Dto;

public sealed class PagedResponseDto<T>
{
    public int Page { get; set; }

    public int PageSize { get; set; }

    public int TotalCount { get; set; }

    public List<T> Items { get; set; } = new();
}