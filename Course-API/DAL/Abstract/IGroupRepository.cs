using Course_API.Entities;

namespace Course_API.DAL.Abstract
{
    public interface IGroupRepository
    {
        void Add(Group group);
        List<Group> GetAll();
        Group GetById(int id);
        List<Group> GetGroups(List<int> ids);
        void Update(Group group);
        void Delete(int id);
    }
}
