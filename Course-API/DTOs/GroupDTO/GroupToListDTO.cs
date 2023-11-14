using Course_API.Entities;

namespace Course_API.DTOs.GroupDTO
{
    public record GroupToListDTO
    {
        public int GroupId { get; set; }
        public int TeacherId { get; set; }
        public string GroupName { get; set; }
        public List<Student> Student { get; set; }

    }
}
