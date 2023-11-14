using Course_API.BLL.Abstract;
using Course_API.DTOs.RoomDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Course_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService= roomService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] RoomToAddDTO roomToAddDTO)
        {
            _roomService.Add(roomToAddDTO);
            return Ok();
        }
        [HttpGet]
        public IActionResult Get()
        {
            var rooms = _roomService.Get();
            return Ok(rooms);
        }
    }
}
