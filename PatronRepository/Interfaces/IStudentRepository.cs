using PatronRepository.Models;

namespace PatronRepository.Interfaces
{
    public interface IStudentRepository : IDisposable
    {
        IEnumerable<Student> GetStudents();
        Student GetSutdentByID(int id);
        void InsertStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
        void Save();
    }
}
