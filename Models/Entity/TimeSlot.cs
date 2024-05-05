namespace MeetingScheduler.Models.Entity
{
    public class TimeSlot
    {

        public Guid Id { get; set; }
        public Guid CalendarId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid TypeId { get; set; }
        public bool PublicBookable { get; set; }
        public bool OutOfOffice { get; set; }
    }
}
