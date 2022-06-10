using System;

namespace L103Exercises1
{
    class InvalidSubjectIdException : Exception
    {
        public string InvalidId { get; set; }
        public InvalidSubjectIdException() : base() { }
        public InvalidSubjectIdException(string message) : base(message) { }
        public InvalidSubjectIdException(string message, Exception innerException) : base(message, innerException) { }
        public InvalidSubjectIdException(string message, string id) : base(message)
        {
            InvalidId = id;
        }

        public override string ToString()
        {
            return base.ToString() + "\nGiá trị không hợp lệ: " + InvalidId;
        }
    }
}
