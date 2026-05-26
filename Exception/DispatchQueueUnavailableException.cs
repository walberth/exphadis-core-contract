namespace Exphadis.Core.Contract.Exception
{
    [Serializable]
    public class DispatchQueueUnavailableException : System.Exception
    {
        public DispatchQueueUnavailableException(string message)
            : base(message)
        {
        }
    }
}