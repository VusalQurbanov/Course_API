using Course_API.Entities;

namespace Course_API.DTOs.TeacherDTO
{
    public record TeacherToUpdateDTO
    {
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public int LessonId { get; set; }
    }

}


