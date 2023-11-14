using Course_API.Entities;

namespace Course_API.DAL.Abstract.ILessonTimes
{
    public interface ILessonHoursRepository
    {
        List<LessonHours> GetLessonHours(List<int> ids);
        List<LessonHours> LessonHours();
    }
}
