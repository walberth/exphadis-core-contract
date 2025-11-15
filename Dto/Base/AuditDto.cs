// <copyright file="AuditDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Exphadis.Core.Contract.Dto.Base;

public class AuditDto
{
    public string UserRegister { get; set; }

    public DateTime TimeRegister { get; set; }

    public string UserUpdated { get; set; }

    public DateTime? TimeUpdated { get; set; }
}
