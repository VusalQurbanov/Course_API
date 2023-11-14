using Course_API.Entities;

namespace Course_API.DTOs.CourseDTO
{
    public record CourseToAddDTO
    {
        public string CourseName { get; set; }
    }
}
