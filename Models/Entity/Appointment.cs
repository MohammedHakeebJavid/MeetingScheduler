public class Appointment
{
    public Guid Id { get; set; }
    public Guid CalendarId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Guid? PatientId { get; set; }
    public string PatientComment { get; set; }
    public string Note { get; set; }
    public Guid? TimeSlotTypeId { get; set; }
    public Guid? TypeId { get; set; }
    public int State { get; set; }
    public string OutOfOfficeLocation { get; set; }
    public bool OutOfOffice { get; set; }
    public bool Completed { get; set; }
    public bool IsScheduled { get; set; }
}