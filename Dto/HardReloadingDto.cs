namespace Exphadis.Core.Contract.Dto;

public class HardReloadingDto
{
    public int UserId { get; set; }

    public DateTime TimeStamp { get; set; }

    public string Ip { get; set; }

    public string Browser { get; set; }
}
