using Course_API.Entities;

namespace Course_API.DAL.Abstract
{
    public interface IRoomRepository
    {
        void Add(Room room);
        List<Room> GetRooms(List<int> ids);
        List<Room> Get();
    }
}
