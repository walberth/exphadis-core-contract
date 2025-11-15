namespace Exphadis.Core.Contract.Exceptions;


public class BusinessException : Exception
{
    public string ValidationMessage { get; set; }

    public ExceptionTypeEnum Type { get; }

    public byte[] ByteArray { get; set; }

    public BusinessException(
        string validationMessage,
        ILogger logger,
        ExceptionTypeEnum type = ExceptionTypeEnum.Default,
        string fileContent = default,
        string username = "",
        string traceIdentifier = "",
        [CallerLineNumber] int lineNumber = 0,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "")
        : base(validationMessage)
    {
        this.ValidationMessage = validationMessage;

        var exceptionMessage = string.IsNullOrEmpty(validationMessage) ? fileContent : validationMessage;

        var message =
            $"[{username}] {traceIdentifier} - [MemberName: {memberName}]{Environment.NewLine}[Line: {lineNumber}]{Environment.NewLine}[Path: {filePath}]{Environment.NewLine}[Validation: {exceptionMessage}]";

        logger.LogWarning(message);

        this.Type = type;

        if (fileContent != default)
        {
            this.ByteArray = System.Text.Encoding.UTF8.GetBytes(fileContent);
        }
    }

    public BusinessException()
    {
    }

    public BusinessException(string message)
        : base(message)
    {
    }

    public BusinessException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
