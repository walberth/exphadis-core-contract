// <copyright file="CertificateConfiguration.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Exphadis.Core.Contract.Dto;

public class CertificateConfiguration
{
    public int? IdCertificateConfiguration { get; set; }

    public int? IdCourseCertificate { get; set; }

    public string NameCourseCertificate { get; set; }

    public CourseDto Course { get; set; }
}
