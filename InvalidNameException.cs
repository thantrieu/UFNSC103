using System;

namespace L103Exercises1
{
    class InvalidNameException : Exception
    {
        public string InvalidNameValue { get; set; }

        public InvalidNameException() : base() { }
        public InvalidNameException(string message) : base(message) { }
        public InvalidNameException(string message, Exception innerException) : base(message, innerException) { }
        public InvalidNameException(string message, string name) : base(message)
        {
            InvalidNameValue = name;
        }

        public override string ToString()
        {
            return base.ToString() + "\nGiá trị tên không hợp lệ: " + InvalidNameValue;
        }
    }
}
