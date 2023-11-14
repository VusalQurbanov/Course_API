using Course_API.BLL.Abstract;
using Course_API.DAL.Abstract;
using Course_API.Entities;

namespace Course_API.DAL.Concrete
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MyContext _myContext;
        public StudentRepository(MyContext myContext)
        {
            _myContext = myContext;
        }
        public void Add(Student student)
        {
            _myContext.Student.Add(student);
            _myContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Student student = _myContext.Student.Single(v => v.StudentId== id);
            _myContext.Student.Remove(student);
            _myContext.SaveChanges();
        }

        public List<Student> Get()
        {
            List<Student> students = _myContext.Student.ToList();
            return students;
        }

        public Student GetById(int id)
        {
            var data = _myContext.Student.Find(id);
            return data;
        }

        public List<Student> GetStudents(List<int> ids)
        {
            var datas = _myContext.Student.Where(v => ids.Contains(v.StudentId)).ToList();
            return datas;
        }

        public void Update(Student student)
        {
            _myContext.Student.Update(student);
            _myContext.SaveChanges();
        }

    }
}
