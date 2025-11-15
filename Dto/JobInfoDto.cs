// Copyright (c) {year} Exphadis. All rights reserved.

#nullable enable

namespace Exphadis.Core.Contract.Dto;

public sealed record JobInfoDto(
    string id,
    string? name,
    JobStatusEnum status,
    DateTimeOffset createdAt,
    DateTimeOffset? startedAt = null,
    DateTimeOffset? finishedAt = null,
    string? error = null);

#nullable restore
