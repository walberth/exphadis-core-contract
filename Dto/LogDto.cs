namespace Exphadis.Core.Contract.Dto;

public class LogDto
{
    public LogTypeEnum Level { get; set; }

    public DateTime TimeStamp { get; set; }

    public string Message { get; set; }

    public string Stack { get; set; }

    public Guid TraceIdentifier { get; set; }

    public string Identifier { get; set; }

    public string Username { get; set; }

    public string CompleteName { get; set; }

    public string Service { get; set; }

    public string Version { get; set; }

    public string Environment { get; set; }
}
