using MeetingScheduler.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace MeetingScheduler.Database
{
    public class MeetingDbContext : DbContext
    {
        public MeetingDbContext(DbContextOptions<MeetingDbContext> options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Calendar> Calendars { get; set; } 
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<TimeSlotType> TimeSlotTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
