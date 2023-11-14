namespace Course_API.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public List<Lesson>? Lesson { get; set; }
        public List<Group>? Group { get; set; }
        public List<Room>? Room { get; set; }
        public List<Student>? Student { get; set; }
        public List<Teacher>? Teacher { get; set; }

    }
}
