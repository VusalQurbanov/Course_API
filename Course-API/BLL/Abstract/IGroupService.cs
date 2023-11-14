using Course_API.DTOs.GroupDTO;

namespace Course_API.BLL.Abstract
{
    public interface IGroupService
    {
        void Add(GroupToAddDTO groupToAddDTO);
        List<GroupToListDTO> GetAll();
        void UpdateStudent(int id,List<int> ids);
        void UpdateDays(int id,List<int> ids);
        void UpdateHours(int id,List<int> ids);
        void Delete(int id);
    }
}
