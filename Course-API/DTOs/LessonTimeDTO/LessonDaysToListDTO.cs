using Course_API.Entities;

namespace Course_API.DTOs.LessonTimeDTO
{
    public record LessonDaysToListDTO
    {
        public int LessonDaysId { get; set; }
        public string Day { get; set; }
    }
}
