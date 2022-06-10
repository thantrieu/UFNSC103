using System;

namespace L103Exercises1
{
    class InvalidBirthDateException : Exception
    {
        public string InvalidBirthDate { get; set; }

        public InvalidBirthDateException() : base() { }
        public InvalidBirthDateException(string message) : base(message) { }
        public InvalidBirthDateException(string message, Exception innerException) : base(message, innerException) { }
        public InvalidBirthDateException(string message, string invalidBirthDate) : base(message)
        {
            InvalidBirthDate = invalidBirthDate;
        }

        public override string ToString()
        {
            return base.ToString() + "\nNgày sinh không hợp lệ: " + InvalidBirthDate;
        }
    }
}
