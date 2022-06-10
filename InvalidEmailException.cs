using System;

namespace L103Exercises1
{
    // lớp mô tả ngoại lệ email không hợp lệ
    class InvalidEmailException : Exception
    {
        public string InvalidEmailValue { get; set; }
        public InvalidEmailException() : base() { }
        public InvalidEmailException(string message) : base(message) { }
        public InvalidEmailException(string message, Exception innerEx) : base(message, innerEx) { }
        public InvalidEmailException(string message, string emailValue) : base(message)
        {
            InvalidEmailValue = emailValue;
        }

        public override string ToString()
        {
            return base.ToString() + "\nGiá trị email không hợp lệ: " + InvalidEmailValue;
        }
    }
}
