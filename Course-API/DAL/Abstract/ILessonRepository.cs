using Course_API.Entities;

namespace Course_API.DAL.Abstract
{
    public interface ILessonRepository
    {
        public List<Lesson> Get();
        Lesson GetById(int id);
        public void AddLesson(Lesson lesson);
        List<Lesson> GetLessons(List<int> ids);
        public void UpdateLesson(Lesson lesson);
        void DeleteLesson(int id);
    }
}
