namespace Exphadis.Core.Contract.Exception
{
    [Serializable]
    public class WhatsAppQueuePublishException : System.Exception
    {
        public string CorrelationId { get; }

        public WhatsAppQueuePublishException(
            string message,
            string correlationId,
            System.Exception innerException = null)
            : base(message, innerException)
        {
            CorrelationId = correlationId;
        }
    }
}
