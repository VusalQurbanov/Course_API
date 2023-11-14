using Course_API.Entities;

namespace Course_API.DAL.Abstract
{
    public interface ICourseRepository
    {
        void Add(Course course);
        void Update(Course course);
        List<Course> GetAll();
        Course GetById(int id);
        void Delete(int id);
    }
}
