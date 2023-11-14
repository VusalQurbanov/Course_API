using Course_API.DAL.Abstract;
using Course_API.Entities;

namespace Course_API.DAL.Concrete
{
    public class RoomRepository : IRoomRepository
    {
        private readonly MyContext _myContext;
        public RoomRepository(MyContext myContext)
        {
             _myContext= myContext;
        }
        public void Add(Room room)
        {
            _myContext.Room.Add(room);
            _myContext.SaveChanges();
        }

        public List<Room> Get()
        {
            var rooms = _myContext.Room.ToList();
            return rooms;
        }

        public List<Room> GetRooms(List<int> ids)
        {
            var datas = _myContext.Room.Where(v=> ids.Contains(v.RoomId)).ToList();
            return datas;
        }
    }
}
