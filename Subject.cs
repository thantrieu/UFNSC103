using System;
using Newtonsoft.Json;

namespace L103Exercises1
{
    // lớp mô tả thông tin môn học
    class Subject : IComparable<Subject>
    {
        [JsonIgnore]
        private static int autoId = 11001;
        [JsonProperty("subjectId")]
        public int SubjectId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("credit")]
        public int Credit { get; set; }
        [JsonProperty("numofLesson")]
        public int NumOfLesson { get; set; }

        public Subject() { }

        public Subject(int id)
        {
            if (id == 0)
            {
                SubjectId = autoId++;
            }
            else
            {
                SubjectId = id;
            }
        }

        public Subject(int id, string name, int credit, int lesson) : this(id)
        {
            Name = name;
            Credit = credit;
            NumOfLesson = lesson;
        }

        public override bool Equals(object obj)
        {
            return obj is Subject subject &&
                   SubjectId == subject.SubjectId;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        internal static void SetAutoId(int v)
        {
            autoId = v;
        }

        public int CompareTo(Subject other)
        {
            if (other == null)
            {
                return -1;
            }
            else
            {
                return SubjectId - other.SubjectId;
            }
        }
    }
}
