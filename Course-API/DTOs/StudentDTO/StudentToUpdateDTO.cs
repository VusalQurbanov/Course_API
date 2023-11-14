namespace Course_API.DTOs.StudentDTO
{
    public record StudentToUpdateDTO
    {
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
    }
}
