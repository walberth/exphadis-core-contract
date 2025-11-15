namespace Exphadis.Core.Contract.Dto;

using Base;

public class WhatsappMessageDto : AuditDto
{
    public string Message { get; set; }

    public IEnumerable<string> Numbers { get; set; }
}
