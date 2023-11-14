namespace Course_API.Entities
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int? TeacherId { get; set; }
        public List<Student>? Student { get; set; }
        public List<LessonDays>? LessonDay { get; set; }
        public List<LessonHours>? LessonHour { get; set; }
        public int? RoomId { get; set; }
        public int CourseId { get; set; }

    }
}
