using System.Collections.Generic;

namespace L103Exercises1
{
    interface IIOController
    {
        void SaveStudentsData(List<Student> students, string fileName);
        void SaveSubjectsData(List<Subject> subjects, string fileName);
        void SaveRegistersData(List<Register> registers, string fileName);
        void UpdateRegisterAutoId(List<Register> registers);
        void UpdateSubjectAutoId(List<Subject> subjects);
        List<Student> GetStudents(string fileName);
        List<Subject> GetSubjects(string fileName);
        List<Register> GetRegisters(string fileName);
    }
}
