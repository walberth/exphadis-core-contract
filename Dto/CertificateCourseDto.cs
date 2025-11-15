// <copyright file="CertificateCourseDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Exphadis.Core.Contract.Dto;

public class CertificateCourseDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int IdLevel { get; set; }

    public string Level { get; set; }

    public string UserRegister { get; set; }

    public DateTime TimeStamp { get; set; }

    public IEnumerable<CertificateNoteDto> CertificateNote { get; set; }
}
