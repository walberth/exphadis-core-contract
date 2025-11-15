namespace Exphadis.Core.Contract.Dto;

public class MenuDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Icon { get; set; }

    public int Order { get; set; }

    public string RedirectTo { get; set; }

    public bool Active { get; set; }

    public int NumberOfChildrens { get; set; }

    public List<MenuDto> Childrens { get; set; } = new();
}
