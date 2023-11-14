namespace Course_API.DTOs.TeacherDTO
{
    public record TeacherToAddDTO
    {
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public int CourseId { get; set; }
    }
}
