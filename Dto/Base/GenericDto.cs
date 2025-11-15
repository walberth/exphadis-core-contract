// <copyright file="GenericDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Exphadis.Core.Contract.Dto.Base;

public class GenericDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Extension { get; set; }

    public bool Active { get; set; }

    public bool Transversal { get; set; }

    public dynamic Value { get; set; }
}
