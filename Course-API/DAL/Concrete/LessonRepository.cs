using Course_API.DAL.Abstract;
using Course_API.Entities;

namespace Course_API.DAL.Concrete
{
    public class LessonRepository : ILessonRepository
    {
        private readonly MyContext _myContext;
        public LessonRepository(MyContext myContext)
        {
            _myContext = myContext;
        }

        public void AddLesson(Lesson lesson)
        {
            _myContext.Lesson.Add(lesson);
            _myContext.SaveChanges();
        }

        public void DeleteLesson(int id)
        {
            var data = _myContext.Lesson.Single(v => v.LessonId == id);
            _myContext.Lesson.Remove(data);
            _myContext.SaveChanges();
        }

        public List<Lesson> Get()
        {
            List<Lesson> lesson = _myContext.Lesson.ToList();
            return lesson;
        }

        public Lesson GetById(int id)
        {
            var lesson = _myContext.Lesson.Find(id);
            return lesson;
        }

        public List<Lesson> GetLessons(List<int> ids)
        {
            var datas = _myContext.Lesson.Where(v=> ids.Contains(v.LessonId)).ToList();
            return datas;
        }

        public void UpdateLesson(Lesson lesson)
        {
            _myContext.Update(lesson);
            _myContext.SaveChanges();
        }

    }
}
