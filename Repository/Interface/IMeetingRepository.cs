namespace MeetingScheduler.Data
{
    public interface IMeetingRepository
    {
        Task<List<Appointment>> GetAppointmentsAsync(List<Guid> calendarIds, DateTime start, DateTime end);
    }
}
