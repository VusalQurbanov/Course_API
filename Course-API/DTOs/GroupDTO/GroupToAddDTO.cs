using Course_API.Entities;

namespace Course_API.DTOs.GroupDTO
{
    public record GroupToAddDTO
    {
        public string GroupName { get; set; }
        public int CourseId { get; set; }

    }
}
