using System;

namespace L103Exercises1
{
    // lớp mô tả ngoại lệ số điện thoại không hợp lệ
    class InvalidPhoneNumberException : Exception
    {
        public string InvalidPhoneNumberValue { get; set; }

        public InvalidPhoneNumberException() : base() { }
        public InvalidPhoneNumberException(string message) : base(message) { }
        public InvalidPhoneNumberException(string message, Exception innerEx) : base(message, innerEx) { }
        public InvalidPhoneNumberException(string message, string phoneNumberValue) : base(message)
        {
            InvalidPhoneNumberValue = phoneNumberValue;
        }

        public override string ToString()
        {
            return base.ToString() + "\nGiá trị số điện thoại không hợp lệ: " + InvalidPhoneNumberValue;
        }
    }
}
