namespace Course_API.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set;}
        public int? GroupId { get; set; }
        public int CourseId { get; set; }

    }

}
