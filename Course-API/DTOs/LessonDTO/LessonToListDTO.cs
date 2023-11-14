using Course_API.Entities;

namespace Course_API.DTOs.LessonDTO
{
    public record LessonToListDTO
    {
        public int LessonId { get; set; }
        public string LessonName { get; set;}
    }
}
