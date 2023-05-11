using PatronRepository.Data;
using PatronRepository.Interfaces;
using PatronRepository.Models;

namespace PatronRepository.Repository
{
    public class StudentRepository : IStudentRepository, IDisposable
    {
        private DataContext _context;

        public StudentRepository(DataContext context)
        {
            _context = context;
        }
        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        public Student GetSutdentByID(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
