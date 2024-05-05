using MeetingScheduler.Data;

namespace MeetingScheduler.Services
{
    public class MeetingService : IMeetingService
    {
        private readonly IMeetingRepository _meetingRepository;

        public MeetingService(IMeetingRepository meetingRepository)
        {
            _meetingRepository = meetingRepository;
        }

        public async Task<List<DateTime>> FindAvailableTimeAsync(List<Guid> calendarIds, int duration, DateTime start, DateTime end, Guid? timeSlotType)
        {
            var appointments = await _meetingRepository.GetAppointmentsAsync(calendarIds, start, end);

            // Generate a list of available times starting from the provided start date
            // For each integer, add i days to the start date and set the time to 9:00 AM
            var availableTimes = Enumerable.Range(0, 10).Select(i => start.AddDays(i).AddHours(9)).ToList();
            return availableTimes;
        }
    }
}
