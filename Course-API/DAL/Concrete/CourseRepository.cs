using Course_API.DAL.Abstract;
using Course_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Course_API.DAL.Concrete
{
    public class CourseRepository : ICourseRepository
    {
        private readonly MyContext _myContext;
        
        public CourseRepository(MyContext myContext)
        {
            _myContext = myContext;
        }
        public void Add(Course course)
        {
            _myContext.Course.Add(course);
            _myContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _myContext.Course.Find(id);
            _myContext.Course.Remove(data);
            _myContext.SaveChanges();
        }

        public List<Course> GetAll()
        {
            var courses = _myContext.Course.Include(v=> v.Teacher).Include(v=> v.Room).Include(c=> c.Group)
                .Include(v=> v.Student).Include(v=> v.Lesson).ToList();
            return courses;
        }

        public Course GetById(int id)
        {
            Course course = _myContext.Course.Find(id);
            return course;
        }

        public void Update(Course course)
        {
            _myContext.Course.Update(course);
            _myContext.SaveChanges();
        }
    }
}
