using System.Text.RegularExpressions;

namespace L103Exercises1
{
    class Filter : IFilter
    {
        public bool IsStudentIdValid(string studentId)
        {
            var pattern = @"^B\d{2}[a-z]{4}\d{3}$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(studentId);
        }

        public bool IsEmailValid(string email)
        {
            var pattern = @"^[a-z0-9_]+[a-z-0-9.-_]*@[a-z-0-9]+\.[a-z]{2,4}$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

        public bool IsNameValid(string name)
        {
            var pattern = @"^[a-z]+[a-z ]*$";
            if (name.Length >= 2 && name.Length <= 40)
            {
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                return regex.IsMatch(name.Trim());
            }
            return false;
        }

        public bool IsPhoneValid(string phone)
        {
            var pattern = @"^(03|08|09)\d{8}$";
            var regex = new Regex(pattern);
            return regex.IsMatch(phone);
        }

        public bool IsBirthDateValid(string birthDate)
        {
            var pattern = @"^\d{2}/\d{2}/\d{4}$";
            var regex = new Regex(pattern);
            return regex.IsMatch(birthDate);
        }

        public bool IsSubjectIdValid(string subjectId)
        {
            var pattern = @"^\d{5}$";
            var regex = new Regex(pattern);
            if(regex.IsMatch(subjectId))
            {
                var value = int.Parse(subjectId);
                return value >= 11001;
            }
            return false;
        }

        public bool IsRegisterIdValid(string registerId)
        {
            var pattern = @"^\d{5}$";
            var regex = new Regex(pattern);
            if (regex.IsMatch(registerId))
            {
                var value = int.Parse(registerId);
                return value >= 10000;
            }
            return false;
        }
    }
}
