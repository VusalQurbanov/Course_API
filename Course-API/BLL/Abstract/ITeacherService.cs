using Course_API.DTOs.TeacherDTO;
using Course_API.Entities;

namespace Course_API.BLL.Abstract
{
    public interface ITeacherService
    {
        void Add(TeacherToAddDTO teacherToAddDTO);
        List<TeacherToListDTO> Get();
        void Update(int id,TeacherToUpdateDTO teacherToUpdateDTO);
        void UpdateGroup(int id,List<int> ids);
        void Delete(int id);
    }
}
