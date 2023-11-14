namespace Course_API.Entities
{
    public class LessonHours
    {
        public int LessonHoursId { get; set; }
        public string Hours { get; set; }
        public List<Group>? Group { get; set; }
    }
}
