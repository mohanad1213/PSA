using AppointmentBooking.Infrastructure.Database.Models;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentBooking.Infrastructure.Database
{
    public class AppointmentBookingDbContext : DbContext
    {
        public AppointmentBookingDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<TimeSlot> timeSlots { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TimeSlot>().HasData(GenerateTimeSlots());
            modelBuilder.Entity<Booking>().HasData(GenerateBookings());
        }

        private List<Booking> GenerateBookings()
        {
            var bookings = new List<Booking>();
            for (int i = 1; i <= 10; i++)
            {
                bookings.Add(new Booking
                {
                    Id = Guid.NewGuid(),
                    SlotId = Guid.NewGuid(),
                    PatientId = Guid.NewGuid(),
                    PatientName = $"Patient {i}",
                    ReservedAt = DateTime.Now.AddDays(i)
                });
            }
            return bookings;
        }

        private List<TimeSlot> GenerateTimeSlots()
        {
            var timeSlots = new List<TimeSlot>();
            for (int i = 1; i <= 10; i++)
            {
                timeSlots.Add(new TimeSlot
                {
                    id = Guid.NewGuid(),
                    time = DateTime.Now.AddHours(i),
                    doctorId = Guid.NewGuid(),
                    doctorName = $"Doctor {i}",
                    isReserved = false,
                    cost = 100 + i * 10
                });
            }
            return timeSlots;
        }
    }
}
