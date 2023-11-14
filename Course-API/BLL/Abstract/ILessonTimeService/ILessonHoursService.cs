using Course_API.DTOs.LessonTimeDTO;

namespace Course_API.BLL.Abstract.ILessonTimeService
{
    public interface ILessonHoursService
    {
        List<LessonHoursToListDTO> GetLessonHours();
    }
}
