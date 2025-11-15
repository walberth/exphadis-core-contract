// <copyright file="AccessDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Exphadis.Core.Contract.Dto;

public class AccessDto
{
    public IEnumerable<RoleDto> Roles { get; set; } = new List<RoleDto>();

    public IEnumerable<PermissionDto> Permissions { get; set; } = new List<PermissionDto>();
}
