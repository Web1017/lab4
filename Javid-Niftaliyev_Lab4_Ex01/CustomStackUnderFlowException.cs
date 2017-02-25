using System;
using System.Runtime.Serialization;

namespace Javid_Niftaliyev_Lab4_Ex01
{
    [Serializable]
    internal class CustomStackUnderFlowException : Exception
    {
        public CustomStackUnderFlowException()
        {
        }

        public CustomStackUnderFlowException(string message) : base(message)
        {
        }

        public CustomStackUnderFlowException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CustomStackUnderFlowException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}