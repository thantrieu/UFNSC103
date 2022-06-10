using System;

namespace L103Exercises1
{
    class InvalidStudentIdException : Exception
    {
        public string InvalidId { get; set; }
        public InvalidStudentIdException() : base() { }
        public InvalidStudentIdException(string message) : base(message) { }
        public InvalidStudentIdException(string message, Exception innerException) : base(message, innerException) { }
        public InvalidStudentIdException(string message, string invalidId) : base(message)
        {
            InvalidId = invalidId;
        }

        public override string ToString()
        {
            return base.ToString() + "\nMã sinh viên không hợp lệ: " + InvalidId;
        }
    }
}

