namespace Exphadis.Core.Contract.Dto;

public class ParentsInformationDto
{
    public int IdPerson { get; set; }

    public int IdStudent { get; set; }

    public int IdParent { get; set; }

    public string CompleteName { get; set; }

    public string FirstName { get; set; }

    public string MotherLastName { get; set; }

    public string FatherLastName { get; set; }

    public bool Sex { get; set; }

    public string Document { get; set; }

    public int DocumentType { get; set; }

    public string Telephone { get; set; }

    public string Mobile { get; set; }

    public int IdRelationshipType { get; set; }

    public string Relationship { get; set; }

    public string Email { get; set; }

    public DateTime BirthDate { get; set; }
}
