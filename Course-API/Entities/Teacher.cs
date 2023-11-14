namespace Course_API.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public List<Group>? Group { get; set; }
        public int CourseId { get; set; }
        public int? LessonId { get; set; }

    }
}
