using Course_API.DTOs.StudentDTO;
using Course_API.Entities;

namespace Course_API.BLL.Abstract
{
    public interface IStudentService
    {
        void Add(StudentToAddDTO studentToAddDTO);
        List<StudentToListDTO> Get();
        void Update(int id,StudentToUpdateDTO studentToUpdateDto);
        void UpdateGroup(int id, int groupid);
        void Delete(int id);
    }
}
