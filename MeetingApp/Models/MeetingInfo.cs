namespace MeetingApp.Models{
    public class MeetingInfo {
        public int Id { get; set; }  
        public string? Location { get; set; }
        public DateTime MeetingDateTime { get; set; }
        public int NumberOfParticipants { get; set; }
    }
}