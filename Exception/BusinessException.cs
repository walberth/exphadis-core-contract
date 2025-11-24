namespace Exphadis.Core.Contract.Exception
{
    [Serializable]
    public class BusinessException : System.Exception
    {
        public string ValidationMessage { get; }
        public ExceptionTypeEnum Type { get; }
        public byte[] ByteArray { get; }

        public BusinessException(
            string validationMessage,
            ExceptionTypeEnum type = ExceptionTypeEnum.Default,
            string fileContent = null,
            [CallerLineNumber] int lineNumber = 0,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePath = "") : base(validationMessage)
        {
            ValidationMessage = validationMessage;
            Type = type;

            if (!string.IsNullOrEmpty(fileContent))
            {
                ByteArray = System.Text.Encoding.UTF8.GetBytes(fileContent);
            }

            Data["LineNumber"] = lineNumber;
            Data["MemberName"] = memberName;
            Data["FilePath"] = filePath;
        }
    }
}
