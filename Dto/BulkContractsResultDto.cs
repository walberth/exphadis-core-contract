namespace Exphadis.Core.Contract.Dto;

using System.Collections.Generic;

public sealed class BulkContractsResultDto
{
    public int TotalCount { get; set; }

    public int SavedCount { get; set; }

    public int ErrorCount { get; set; }

    public List<BulkContractErrorDto> Errors { get; set; } = new();
}

public sealed class BulkContractErrorDto
{
    public int Row { get; set; }

    public int WorkerId { get; set; }

    public string Message { get; set; }
}
