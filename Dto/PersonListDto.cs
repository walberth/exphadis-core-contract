namespace Exphadis.Core.Contract.Dto;

public class PersonListDto
{
    public int IdPerson { get; set; }

    public string CompleteName { get; set; }

    public string FirstName { get; set; }

    public string FatherLastName { get; set; }

    public string MotherLastName { get; set; }

    public int PersonType { get; set; }

    public bool Sex { get; set; }

    public DateTime BirthDate { get; set; }

    public int DocumentType { get; set; }

    public string Document { get; set; }

    public string Email { get; set; }

    public string Telephone { get; set; }

    public string Mobile { get; set; }

    public int IdDepartment { get; set; }

    public int IdProvince { get; set; }

    public int IdDistrict { get; set; }

    public string Direction { get; set; }

    public int IdGradeInstruction { get; set; }

    public string Ocupation { get; set; }

    public int IdRelationshipType { get; set; }

    public string WorkCenter { get; set; }

    public int IdAttorney { get; set; }

    public int IdParent { get; set; }

    public string UbigeoDepartment { get; set; }

    public string UbigeoProvince { get; set; }

    public string UbigeoDistrict { get; set; }
}
