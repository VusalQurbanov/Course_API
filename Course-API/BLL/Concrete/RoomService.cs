using AutoMapper;
using Course_API.BLL.Abstract;
using Course_API.DAL.Abstract;
using Course_API.DTOs.RoomDTO;
using Course_API.Entities;

namespace Course_API.BLL.Concrete
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;
        public RoomService(IRoomRepository roomRepository,IMapper mapper)
        {
            _roomRepository = roomRepository;
            _mapper = mapper;
        }

        public void Add(RoomToAddDTO roomToAddDTO)
        {
            var room = _mapper.Map<Room>(roomToAddDTO);
            _roomRepository.Add(room);
        }

        public List<RoomToListDTO> Get()
        {
            var rooms = _mapper.Map<List<RoomToListDTO>>(_roomRepository.Get());
            return rooms;
        }

    }
}
