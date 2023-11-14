namespace Course_API.DTOs.StudentDTO
{
    public record StudentToListDTO
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int GroupId { get; set; }
    }
}
