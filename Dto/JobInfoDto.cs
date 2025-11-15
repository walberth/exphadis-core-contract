// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Application.Dto
{
    public sealed record JobInfoDto(
    string id,
    string? name,
    JobStatusEnum status,
    DateTimeOffset createdAt,
    DateTimeOffset? startedAt = null,
    DateTimeOffset? finishedAt = null,
    string? error = null);
}
