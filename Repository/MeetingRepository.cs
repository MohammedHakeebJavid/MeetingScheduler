using MeetingScheduler.Database;
using Microsoft.EntityFrameworkCore;

namespace MeetingScheduler.Data
{
    public class MeetingRepository : IMeetingRepository
    {
        private readonly MeetingDbContext _context;

        public MeetingRepository(MeetingDbContext context)
        {
            _context = context;
        }

        public async Task<List<Appointment>> GetAppointmentsAsync(List<Guid> calendarIds, DateTime start, DateTime end)
        {
            // Filter appointments where calendarId is included in the provided list of calendarIds,start,end
            return await _context.Appointments
                .Where(a => calendarIds.Contains(a.CalendarId) && a.StartTime >= start && a.EndTime <= end)
                .ToListAsync();
        }
    }
}