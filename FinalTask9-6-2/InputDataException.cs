using System.Runtime.Serialization;

namespace FinalTask9_6_2
{
    [Serializable]
    internal class InputDataException : Exception
    {
        public InputDataException()
        {
        }

        public InputDataException(string? message) : base(message)
        {
            base.HelpLink = "http://www.google.com";
            base.Data.Add("Время", DateTime.Now);
        }

        public InputDataException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InputDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}