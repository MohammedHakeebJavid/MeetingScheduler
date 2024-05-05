namespace MeetingScheduler.Services
{
    public interface IMeetingService
    {
        Task<List<DateTime>> FindAvailableTimeAsync(List<Guid> calendarIds, int duration, DateTime start, DateTime end, Guid? timeSlotType);
    }
}
