// <copyright file="InMemoryFileDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Exphadis.Core.Contract.Dto.Base;

public class InMemoryFileDto
{
    public string FileName { get; set; }

    public byte[] Content { get; set; }

    public MemoryStream Stream { get; set; }
}
