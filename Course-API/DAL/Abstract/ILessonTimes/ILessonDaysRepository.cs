using Course_API.Entities;

namespace Course_API.DAL.Abstract.ILessonTimes
{
    public interface ILessonDaysRepository
    {
        List<LessonDays> GetLessonDays(List<int> ids);
        List<LessonDays> LessonDays();
    }
}
