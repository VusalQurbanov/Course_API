using Course_API.Entities;

namespace Course_API.DAL.Abstract
{
    public interface ITeacherRepository
    {
        void Add(Teacher teacher);
        List<Teacher> Get();
        Teacher GetById(int id);
        List<Teacher> GetTeachers(List<int> ids);
        void Update(Teacher teacher);
        void Delete(int id);
    }
}
