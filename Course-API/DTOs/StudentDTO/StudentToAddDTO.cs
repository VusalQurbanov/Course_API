namespace Course_API.DTOs.StudentDTO
{
    public record StudentToAddDTO
    {
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int CourseId { get; set; }
    }
}
