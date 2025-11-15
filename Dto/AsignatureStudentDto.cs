// <copyright file="AsignatureStudentDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Exphadis.Core.Contract.Dto;

public class AsignatureStudentDto
{
    public int Id { get; set; }

    public int Year { get; set; }

    public StudentDto Student { get; set; }

    public EnrollmentDto Enrollment { get; set; }
}
