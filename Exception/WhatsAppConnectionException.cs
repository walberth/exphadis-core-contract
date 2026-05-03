namespace Exphadis.Core.Contract.Exception
{
    [Serializable]
    public class WhatsAppConnectionException : System.Exception
    {
        public string ErrorCode { get; }
        public string ConnectionStatus { get; }
        public string GatewayTraceId { get; }

        public WhatsAppConnectionException(
            string errorCode,
            string errorMessage,
            string connectionStatus = null,
            string gatewayTraceId = null)
            : base(errorMessage)
        {
            ErrorCode = errorCode;
            ConnectionStatus = connectionStatus;
            GatewayTraceId = gatewayTraceId;
        }
    }
}
