using Course_API.Entities;
using Course_API.DTOs.TeacherDTO;

namespace Course_API.DTOs.LessonDTO
{
    public record LessonToAddDTO
    {
        public int CourseId { get; set; }
        public string LessonName { get; set; }
    }
}
