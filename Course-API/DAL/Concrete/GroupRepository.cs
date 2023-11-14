using Course_API.DAL.Abstract;
using Course_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Course_API.DAL.Concrete
{
    public class GroupRepository : IGroupRepository
    {
        private readonly MyContext _myContext;
        public GroupRepository(MyContext myContext)
        {
            _myContext = myContext;
        }
        public void Add(Group group)
        {
            _myContext.Group.Add(group);
            _myContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var group = _myContext.Group.Find(id);
            _myContext.Group.Remove(group);
            _myContext.SaveChanges();
        }

        public List<Group> GetAll()
        {
            var groups = _myContext.Group.Include(v=> v.Student).ToList();
            return groups;
        }

        public Group GetById(int id)
        {
            var gr = _myContext.Group.Find(id);
            return gr;
        }

        public List<Group> GetGroups(List<int> ids)
        {
            var datas = _myContext.Group.Where(v=> ids.Contains(v.GroupId)).ToList();
            return datas;
        }

        public void Update(Group group)
        {
            _myContext.Group.Update(group);
            _myContext.SaveChanges();
        }
    }
}
