namespace Exphadis.Core.Contract.Dto;

using Base;

public class PersonDto : AuditDto
{
    public int Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string MotherLastName { get; set; } = string.Empty;

    public string FatherLastName { get; set; } = string.Empty;

    public string CompleteName { get; set; } = string.Empty;

    public int IdRelationshipType { get; set; } = 0;

    public bool Sex { get; set; }

    public DateTime? BirthDate { get; set; }

    public int Age { get; set; }

    public int PersonType { get; set; }

    public string BusinessName { get; set; } = string.Empty;

    public int DocumentType { get; set; }

    public string Document { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Mobile { get; set; } = string.Empty;

    public string Telephone { get; set; } = string.Empty;

    public string ImageUrl { get; set; }

    public DirectionDto Direction { get; set; }

    public UserDto User { get; set; }
}

public class ContactDto
{
    public string Id { get; set; }

    public string ImageUrl { get; set; }

    public string CompleteName { get; set; }
}
