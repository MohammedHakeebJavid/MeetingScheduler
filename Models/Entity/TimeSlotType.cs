namespace MeetingScheduler.Models.Entity
{
    public class TimeSlotType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int SlotSize { get; set; }
        public bool PublicBookable { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; } 
        public Guid ClinicId { get; set; } 
        public bool Deleted { get; set; }
        public bool OutOfOffice { get; set; }
        public bool Enabled { get; set; }
    }
}
