using System;

namespace L103Exercises1
{
    class InvalidRegisterIdException : Exception
    {
        public string InvalidId { get; set; }
        public InvalidRegisterIdException() : base() { }
        public InvalidRegisterIdException(string message) : base(message) { }
        public InvalidRegisterIdException(string message, Exception innerException) : base(message, innerException) { }
        public InvalidRegisterIdException(string message, string id) : base(message)
        {
            InvalidId = id;
        }

        public override string ToString()
        {
            return base.ToString() + "\nMã không hợp lệ: " + InvalidId;
        }
    }
}
