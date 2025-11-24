namespace Exphadis.Core.Contract.Exception
{
    public class BusinessException : System.Exception
    {
        public string ValidationMessage { get; set; }

        public ExceptionTypeEnum Type { get; }

        public byte[] ByteArray { get; set; }

        public BusinessException(
            string validationMessage,
            ILogger logger,
            ExceptionTypeEnum type = ExceptionTypeEnum.Default,
            string fileContent = default,
            [CallerLineNumber] int lineNumber = 0,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePath = "")
            : base(validationMessage)
        {
            this.ValidationMessage = validationMessage;

            var exceptionMessage = string.IsNullOrEmpty(validationMessage) ? fileContent : validationMessage;

            var message = $"[{Constant.Username}] {Constant.TraceIdentifier} - [MemberName: {memberName}]{Environment.NewLine}[Line: {lineNumber}]{Environment.NewLine}[Path: {filePath}]{Environment.NewLine}[Validation: {exceptionMessage}]";

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

        public BusinessException(string message) : base(message)
        {
        }

        public BusinessException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}
