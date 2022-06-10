using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace L103Exercises1
{
    class IOController : IIOController
    {
        public List<Register> GetRegisters(string fileName)
        {
            FileInfo fileReader = new FileInfo(fileName);
            if (fileReader.Exists)
            {
                List<Register> registers = new List<Register>();
                using (StreamReader stream = fileReader.OpenText())
                {
                    var data = stream.ReadToEnd();
                    try
                    {
                        var jObject = JObject.Parse(data);
                        var jArray = jObject["registers"];
                        foreach (var item in jArray)
                        {
                            registers.Add(item.ToObject<Register>());
                        }
                    }
                    catch (JsonReaderException e)
                    {
                        Console.WriteLine(e);
                    }
                }
                return registers;
            }
            else
            {
                throw new FileNotFoundException("File dữ liệu đăng ký không tồn tại");
            }
        }

        public List<Student> GetStudents(string fileName)
        {
            FileInfo fileReader = new FileInfo(fileName);
            if (fileReader.Exists)
            {
                List<Student> students = new List<Student>();
                using (StreamReader stream = fileReader.OpenText())
                {
                    var data = stream.ReadToEnd();
                    try
                    {
                        var jObject = JObject.Parse(data);
                        var jArray = jObject["students"];
                        foreach (var item in jArray)
                        {
                            students.Add(item.ToObject<Student>());
                        }
                    }
                    catch (JsonReaderException e)
                    {
                        Console.WriteLine(e);
                    }
                }
                return students;
            }
            else
            {
                throw new FileNotFoundException("File dữ liệu sinh viên không tồn tại");
            }
        }

        public List<Subject> GetSubjects(string fileName)
        {
            FileInfo fileReader = new FileInfo(fileName);
            if (fileReader.Exists)
            {
                List<Subject> subjects = new List<Subject>();
                using (StreamReader sr = fileReader.OpenText())
                {
                    var data = sr.ReadToEnd();
                    try
                    {
                        var jObject = JObject.Parse(data);
                        var jArray = jObject["subjects"];
                        foreach (var item in jArray)
                        {
                            subjects.Add(item.ToObject<Subject>());
                        }
                    }
                    catch (JsonReaderException e)
                    {
                        Console.WriteLine(e);
                    }
                }
                return subjects;
            }
            else
            {
                throw new FileNotFoundException("File dữ liệu  môn học không tồn tại");
            }
        }

        public void SaveRegistersData(List<Register> registers, string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            fileInfo.Delete();
            using (StreamWriter sw = new StreamWriter(fileInfo.OpenWrite()))
            {
                var root = new { registers };
                var strJson = JsonConvert.SerializeObject(root, Formatting.Indented);
                sw.Write(strJson);
            }
        }

        public void SaveStudentsData(List<Student> students, string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            fileInfo.Delete();
            using (StreamWriter sw = new StreamWriter(fileInfo.OpenWrite()))
            {
                var root = new { students };
                var strJson = JsonConvert.SerializeObject(root, Formatting.Indented);
                sw.Write(strJson);
            }
        }

        public void SaveSubjectsData(List<Subject> subjects, string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            fileInfo.Delete();
            using (StreamWriter sw = new StreamWriter(fileInfo.OpenWrite()))
            {
                var root = new { subjects };
                var strJson = JsonConvert.SerializeObject(root, Formatting.Indented);
                sw.Write(strJson);
            }
        }

        public void UpdateRegisterAutoId(List<Register> registers)
        {
            int maxId = FindMaxId();
            Register.SetAutoId(maxId + 1);
            int FindMaxId()
            {
                int max = 0;
                foreach (var item in registers)
                {
                    if (item.RegisterId > max)
                    {
                        max = item.RegisterId;
                    }
                }
                return max;
            }
        }

        public void UpdateSubjectAutoId(List<Subject> subjects)
        {
            int maxId = FindMaxId();
            Subject.SetAutoId(maxId + 1);
            int FindMaxId()
            {
                int max = 0;
                foreach (var item in subjects)
                {
                    if (item.SubjectId > max)
                    {
                        max = item.SubjectId;
                    }
                }
                return max;
            }
        }
    }
}
