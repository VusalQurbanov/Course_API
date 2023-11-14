using Course_API.DTOs.GroupDTO;
using Course_API.DTOs.LessonDTO;
using Course_API.DTOs.RoomDTO;
using Course_API.DTOs.StudentDTO;
using Course_API.DTOs.TeacherDTO;
using Course_API.Entities;

namespace Course_API.DTOs.CourseDTO
{
    public record CourseToListDTO
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public List<GroupToListDTO> Group { get; set; }
        public List<LessonToListDTO> Lesson { get; set; }
        public List<RoomToListDTO> Room { get; set; }
        public List<StudentToListDTO> Student { get; set; }
        public List<TeacherToListDTO> Teacher { get; set; }
    }
}
