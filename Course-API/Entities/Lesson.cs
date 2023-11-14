namespace Course_API.Entities
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string LessonName { get; set;}
        public int CourseId { get; set;}
        public List<Teacher>? Teacher { get; set; }
        public List<Group>? Groups { get; set; }
    }
}
