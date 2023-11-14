using Course_API.Entities;

namespace Course_API.DTOs.RoomDTO
{
    public record RoomToAddDTO
    {
        public string RoomNumber { get; set; }
    }
}
