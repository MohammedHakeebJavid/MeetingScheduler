using MeetingScheduler.Database;
using MeetingScheduler.Models.Entity;

namespace YourNamespace
{
    public static class DataSeeder
    {
        public static void SeedData(IServiceProvider serviceProvider)
        {
            using (var context = serviceProvider.GetRequiredService<MeetingDbContext>())
            {
                // Check if the database already contains any data
                if (context.Calendars.Any() || context.Appointments.Any() || context.TimeSlots.Any() || context.TimeSlotTypes.Any())
                {
                    return;
                }

                // Seed calendars
                var calendars = new[]
                {
                    new Calendar
                    {
                        Id = new Guid("48644c7a-975e-11e5-a090-c8e0eb18c1e9"),
                        OwnerName = "Joanna Hef"
                    },
                    new Calendar
                    {
                        Id = new Guid("48cadf26-975e-11e5-b9c2-c8e0eb18c1e9"),
                        OwnerName = "Danny Boy"
                    },
                    new Calendar
                    {
                        Id = new Guid("452dccfc-975e-11e5-bfa5-c8e0eb18c1e9"),
                        OwnerName = "Emma Win"
                    },
                };

                context.Calendars.AddRange(calendars);

                // Seed appointments
                var appointments = new[]
                {
                    new Appointment
                    {
                        Id = new Guid("1847c677-1be8-4e44-a84b-edd6751e8302"),
                        CalendarId = calendars[1].Id, // Connect to Danny Boy's calendar
                        StartTime = DateTime.Parse("2019-04-23T12:15:00"),
                        EndTime = DateTime.Parse("2019-04-23T12:30:00"),
                        PatientId = new Guid("1bee2bf0-9751-11e5-bc1b-c8e0eb18c1e9"),
                        PatientComment = "Patient comment here",
                        Note = "Note here",
                        TimeSlotTypeId = new Guid("452935de-975e-11e5-ae1a-c8e0eb18c1e9"),
                        TypeId = null,
                        State = 0,
                        OutOfOfficeLocation = "",
                        OutOfOffice = false,
                        Completed = true,
                        IsScheduled = false
                    },
                };

                context.Appointments.AddRange(appointments);

                // Seed time slot types
                var timeSlotTypes = new[]
                {
                    new TimeSlotType
                    {
                        Id = new Guid("your-type-guid-1"),
                        Name = "Type 1",
                        SlotSize = 60, // 60 minutes
                        PublicBookable = true,
                        Color = "#ccc",
                        Icon = "icon-home",
                        ClinicId = new Guid("00000000-0000-4000-a002-000000000002"),
                        Deleted = false,
                        OutOfOffice = false,
                        Enabled = false
                    },
                };

                context.TimeSlotTypes.AddRange(timeSlotTypes);

                // Seed time slots
                var timeSlots = new[]
                {
                    new TimeSlot
                    {
                        Id = new Guid("your-time-slot-guid-1"),
                        CalendarId = calendars[0].Id, // Connect to Joanna Hef's calendar
                        StartTime = DateTime.Parse("2024-05-01T09:00:00"),
                        EndTime = DateTime.Parse("2024-05-01T10:00:00"),
                        TypeId = timeSlotTypes[0].Id, // Connect to Type 1 time slot type
                        PublicBookable = true,
                        OutOfOffice = false
                    },
                };

                context.TimeSlots.AddRange(timeSlots);
                context.SaveChanges();
            }
        }
    }
}
