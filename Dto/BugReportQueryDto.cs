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
    public int TotalCount { get; set; }

    public int TotalWithScreenshot { get; set; }

    public int TotalWithHttpErrors { get; set; }

    public List<BugReportItemDto> Items { get; set; } = new();
}

public sealed class BugReportItemDto
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? ScreenshotUrl { get; set; }

    public string CreatedAt { get; set; } = string.Empty;

    public BugReportUserResponseDto User { get; set; } = new();

    public BugReportContextResponseDto Context { get; set; } = new();

    public List<BugReportHttpTraceResponseDto> HttpTrace { get; set; } = new();
}

public sealed class BugReportUserResponseDto
{
    public int UserId { get; set; }

    public string CompleteName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public List<int> Roles { get; set; } = new();
}

public sealed class BugReportContextResponseDto
{
    public string Url { get; set; } = string.Empty;

    public string Path { get; set; } = string.Empty;

    public string QueryParams { get; set; } = string.Empty;

    public string UserAgent { get; set; } = string.Empty;

    public string Timestamp { get; set; } = string.Empty;

    public string ScreenResolution { get; set; } = string.Empty;

    public string? ComponentName { get; set; }
}

public sealed class BugReportHttpTraceResponseDto
{
    public string Id { get; set; } = string.Empty;

    public string Method { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;

    public int? Status { get; set; }

    public long? DurationMs { get; set; }

    public string Timestamp { get; set; } = string.Empty;

    public bool IsError { get; set; }

    public string? ErrorMessage { get; set; }

    public string? RequestBody { get; set; }

    public string? ResponseBody { get; set; }
}
