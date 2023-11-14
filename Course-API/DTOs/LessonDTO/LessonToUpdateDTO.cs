using Course_API.Entities;

namespace Course_API.DTOs.LessonDTO
{
    public record LessonToUpdateDTO
    {
        public string LessonName { get; set; }
        public int CourseId { get; set; }
    }
}
