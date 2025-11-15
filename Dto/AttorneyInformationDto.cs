// <copyright file="AttorneyInformationDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Exphadis.Core.Contract.Dto;

public class AttorneyInformationDto
{
    public int IdPerson { get; set; }

    public int IdAttorney { get; set; }

    public int IdStudent { get; set; }

    public string FirstName { get; set; }

    public string FatherLastName { get; set; }

    public string MotherLastName { get; set; }

    public string CompleteName { get; set; }

    public bool Sex { get; set; }

    public string Document { get; set; }

    public int DocumentType { get; set; }

    public string Telephone { get; set; }

    public string Mobile { get; set; }

    public int IdGradeInstructionType { get; set; }

    public int IdRelationshipType { get; set; }

    public string Relationship { get; set; }

    public string WorkCenter { get; set; }

    public string Occupation { get; set; }

    public string Email { get; set; }

    public int PersonType { get; set; }

    public DateTime BirthDate { get; set; }

    public string GradeInstructionType { get; set; }

    public IEnumerable<DirectionDto> Directions { get; set; } = new List<DirectionDto>();
}
