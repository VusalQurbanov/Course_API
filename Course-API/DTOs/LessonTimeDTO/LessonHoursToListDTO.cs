using Course_API.Entities;

namespace Course_API.DTOs.LessonTimeDTO
{
    public record LessonHoursToListDTO
    {
        public int LessonHoursId { get; set; }
        public string Hours { get; set; }
    }
}
