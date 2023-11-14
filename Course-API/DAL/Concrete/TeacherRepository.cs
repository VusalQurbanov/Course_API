using Course_API.DAL.Abstract;
using Course_API.Entities;

namespace Course_API.DAL.Concrete
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly MyContext _myContext;
        public TeacherRepository(MyContext myContext)
        {
            _myContext = myContext;
        }
        public void Add(Teacher teacher)
        {
            _myContext.Teacher.Add(teacher);
            _myContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var teacher = _myContext.Teacher.Find(id);
            _myContext.Teacher.Remove(teacher);
            _myContext.SaveChanges();

        }

        public List<Teacher> Get()
        {
            var teachers = _myContext.Teacher.ToList();
            return teachers;
        }

        public Teacher GetById(int id)
        {
            var teacher = _myContext.Teacher.Find(id);
            return teacher;
        }

        public List<Teacher> GetTeachers(List<int> ids)
        {
            var datas = _myContext.Teacher.Where(v => ids.Contains(v.TeacherId)).ToList();
            return datas;
        }

        public void Update(Teacher teacher)
        {
            _myContext.Teacher.Update(teacher);
            _myContext.SaveChanges();
        }

    }
}
