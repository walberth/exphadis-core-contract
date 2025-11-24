namespace Exphadis.Core.Contract.Exception
{
    using System.Net;

    public class ExternalApiException : System.Exception
    {
        public HttpStatusCode StatusCode { get; }
        public string ResponseBody { get; }
        public string Endpoint { get; }
        public string CorrelationId { get; }
        public ExternalApiErrorTypeEnum ErrorType { get; }

        public ExternalApiException(
            string message,
            HttpStatusCode statusCode,
            string? responseBody = null,
            string? endpoint = null,
            string? correlationId = null,
            ExternalApiErrorTypeEnum errorType = ExternalApiErrorTypeEnum.Default,
            System.Exception? innerException = null,
            [CallerLineNumber] int lineNumber = 0,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePath = "") : base(message, innerException)
        {
            StatusCode = statusCode;
            ResponseBody = responseBody;
            Endpoint = endpoint;
            CorrelationId = correlationId;
            ErrorType = errorType;

            // Si quieres conservar la “traza de origen” tipo BusinessException:
            Data["CallerLineNumber"] = lineNumber;
            Data["CallerMemberName"] = memberName;
            Data["CallerFilePath"] = filePath;
        }
    }
}
