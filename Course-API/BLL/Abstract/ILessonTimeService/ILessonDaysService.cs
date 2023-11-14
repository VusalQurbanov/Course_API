using AutoMapper;
using Course_API.DTOs.LessonTimeDTO;

namespace Course_API.BLL.Abstract.ILessonTimeService
{
    public interface ILessonDaysService
    {
        List<LessonDaysToListDTO> GetLessonDays();
    }
}
