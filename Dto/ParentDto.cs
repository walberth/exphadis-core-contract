namespace Exphadis.Core.Contract.Dto;

public class ParentDto
{
    public int Id { get; set; }

    public int IdStudent { get; set; }

    public int IdRelationshipType { get; set; }

    public PersonDto Person { get; set; }

    public RelationshipTypeDto RelationshipType { get; set; }
}
