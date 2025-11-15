namespace Exphadis.Core.Contract.Dto;

using Enums;

public class TelegramMessageDto
{
    public IEnumerable<string> Numbers { get; set; }

    public string Message { get; set; }

    public TelegramParseModeEnum ParseMode { get; set; }
}
