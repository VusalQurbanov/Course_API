using System.Diagnostics.Contracts;

namespace Course_API.DTOs.TeacherDTO
{
    public record TeacherToListDTO
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public int LessonId { get; set; }  
    }
}
