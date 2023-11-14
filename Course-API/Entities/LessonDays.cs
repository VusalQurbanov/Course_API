namespace Course_API.Entities
{
    public class LessonDays
    {
        public int LessonDaysId { get; set; }
        public string Day { get; set; }
        public List<Group>? Group { get; set; }
    }
}
