using System;
using System.Runtime.Serialization;

namespace Javid_Niftaliyev_Lab4_Ex01
{
    [Serializable]
    internal class CustomStackOverFlowException : Exception
    {
        public CustomStackOverFlowException()
        {
        }

        public CustomStackOverFlowException(string message) : base(message)
        {
        }

        public CustomStackOverFlowException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CustomStackOverFlowException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}