using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace L103Exercises1
{
    // lớp mô tả thông tin đăng ký
    class Register : IComparable<Register>
    {
        [JsonIgnore]
        private static int autoId = 10000;
        [JsonProperty("registerId")]
        public int RegisterId { get; set; }
        [JsonProperty("registerTime")]
        public DateTime RegisterTime { get; set; }
        [JsonProperty("student")]
        public Student Student { get; set; }
        [JsonProperty("subject")]
        public Subject Subject { get; set; }

        public Register() { }

        public Register(int id)
        {
            if (id == 0)
            {
                RegisterId = autoId++;
            }
            else
            {
                RegisterId = id;
            }
        }

        public Register(int id, Student student, Subject subject, DateTime registerTime) : this(id)
        {
            Student = student;
            Subject = subject;
            RegisterTime = registerTime;
        }

        public override bool Equals(object obj)
        {
            return obj is Register register &&
                   EqualityComparer<Student>.Default.Equals(Student, register.Student) &&
                   EqualityComparer<Subject>.Default.Equals(Subject, register.Subject);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        internal static void SetAutoId(int v)
        {
            autoId = v;
        }

        public int CompareTo(Register other)
        {
            return RegisterId.CompareTo(other.RegisterId);
        }
    }
}
