namespace Exphadis.Core.Contract.Dto;

public class LogDto
{
    public LogTypeEnum Level { get; set; }

    public DateTime TimeStamp { get; set; }

    public string Message { get; set; }

    public string Stack { get; set; }

    public Guid TraceIdentifier { get; set; }

    public string AppName { get; set; }
}
