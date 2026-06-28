// Copyright (c) 2025 Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Dto;

public sealed class BugReportFilterDto
{
    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public string? Search { get; set; }

    public int Page { get; set; } = 1;

    public int PageSize { get; set; } = 25;
}

public sealed class BugReportListResponseDto
{
    public List<BugReportItemDto> Items { get; set; } = new();

    public int TotalCount { get; set; }
}

public sealed class BugReportItemDto
{
    public int Id { get; set; }

    public string Description { get; set; }

    public string ScreenshotUrl { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; }

    public string UserEmail { get; set; }

    public string Roles { get; set; }

    public string Url { get; set; }

    public string Path { get; set; }

    public string QueryParams { get; set; }

    public string UserAgent { get; set; }

    public DateTime OccurredAt { get; set; }

    public string ScreenResolution { get; set; }

    public string ComponentName { get; set; }

    public int TraceCount { get; set; }

    public int ErrorsInTrace { get; set; }

    public int? LastErrorStatus { get; set; }

    public string LastErrorUrl { get; set; }

    public string HttpTrace { get; set; }

    public bool HasScreenshot { get; set; }

    public DateTime TimeRegister { get; set; }
}
