namespace Course_API.Entities
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public List<Course> Course { get; set; }
    }
}
