using Course_API.DTOs.LessonDTO;
using Course_API.Entities;

namespace Course_API.BLL.Abstract
{
    public interface ILessonService
    {
        List<LessonToListDTO> GetAll();
        void AddLesson(LessonToAddDTO lessonAddDto);
        void UpdateLesson(int id,LessonToUpdateDTO lessonToUpdateDTO);
        void UpdateTeacher(int id,List<int> ids);
        void UpdateGroup(int id,List<int> ids);
        void DeleteLesson(int id);
    }
}
