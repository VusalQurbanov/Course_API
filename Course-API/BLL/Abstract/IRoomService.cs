using Course_API.DTOs.RoomDTO;
using Course_API.Entities;

namespace Course_API.BLL.Abstract
{
    public interface IRoomService
    {
        void Add(RoomToAddDTO roomToAddDTO);
        List<RoomToListDTO> Get();
    }
}
