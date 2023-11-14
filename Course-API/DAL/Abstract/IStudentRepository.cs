using Course_API.Entities;

namespace Course_API.DAL.Abstract
{
    public interface IStudentRepository
    {
        void Add(Student student);
        List<Student> Get();
        Student GetById(int id);
        List<Student> GetStudents(List<int> ids);
        void Update(Student student);
        void Delete(int id);
    }
}
