// <copyright file="AttorneyDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Exphadis.Core.Contract.Dto;

using Base;

public class AttorneyDto : AuditDto
{
    public int Id { get; set; }

    public int IdGradeIntruction { get; set; }

    public int IdRelationshipType { get; set; }

    public string Workcenter { get; set; } = string.Empty;

    public string Ocupation { get; set; } = string.Empty;

    public PersonDto Person { get; set; }
}
