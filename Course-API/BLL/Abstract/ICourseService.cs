using Course_API.DTOs.CourseDTO;

namespace Course_API.BLL.Abstract
{
    public interface ICourseService
    {
        void Add(CourseToAddDTO courseToAddDTO);
        void UpdateTeacher(int id,List<int> ids);
        void UpdateGroup(int id, List<int> ids);
        void UpdateLesson(int id, List<int> ids);
        void UpdateRoom(int id, List<int> ids);
        void UpdateStudent(int id, List<int> ids);
        List<CourseToListDTO> GetAll();
        void Delete(int id);
    }
}
