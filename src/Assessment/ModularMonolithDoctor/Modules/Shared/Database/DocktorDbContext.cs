using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Database
{
    public class DocktorDbContext : DbContext
    {
        public DocktorDbContext(DbContextOptions<DocktorDbContext> options) : base(options)
        {
            this.timeSlots.Add(new TimeSlot() { id = Guid.NewGuid(), time = DateTime.Now.AddHours(1), doctorId = Guid.NewGuid(), doctorName = "Dr. Smith", isReserved = false, cost = 100 });

            this.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "InMemoryDb");
        }

        // Define DbSets for your entities
        public virtual DbSet<TimeSlot> timeSlots { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TimeSlot>().HasData(
                new TimeSlot { id = Guid.NewGuid(), time = DateTime.Now.AddHours(1), doctorId = Guid.NewGuid(), doctorName = "Dr. Smith", isReserved = false, cost = 100 },
                new TimeSlot { id = Guid.NewGuid(), time = DateTime.Now.AddHours(2), doctorId = Guid.NewGuid(), doctorName = "Dr. Smith", isReserved = false, cost = 100 },
                new TimeSlot { id = Guid.NewGuid(), time = DateTime.Now.AddHours(3), doctorId = Guid.NewGuid(), doctorName = "Dr. Smith", isReserved = false, cost = 100 },
                new TimeSlot { id = Guid.NewGuid(), time = DateTime.Now.AddHours(4), doctorId = Guid.NewGuid(), doctorName = "Dr. Smith", isReserved = false, cost = 100 },
                new TimeSlot { id = Guid.NewGuid(), time = DateTime.Now.AddHours(5), doctorId = Guid.NewGuid(), doctorName = "Dr. Smith", isReserved = false, cost = 100 },
                new TimeSlot { id = Guid.NewGuid(), time = DateTime.Now.AddHours(6), doctorId = Guid.NewGuid(), doctorName = "Dr. Smith", isReserved = false, cost = 100 },
                new TimeSlot { id = Guid.NewGuid(), time = DateTime.Now.AddHours(7), doctorId = Guid.NewGuid(), doctorName = "Dr. Smith", isReserved = false, cost = 100 },
                new TimeSlot { id = Guid.NewGuid(), time = DateTime.Now.AddHours(8), doctorId = Guid.NewGuid(), doctorName = "Dr. Smith", isReserved = false, cost = 100 },
                new TimeSlot { id = Guid.NewGuid(), time = DateTime.Now.AddHours(9), doctorId = Guid.NewGuid(), doctorName = "Dr. Smith", isReserved = false, cost = 100 },
                new TimeSlot { id = Guid.NewGuid(), time = DateTime.Now.AddHours(10), doctorId = Guid.NewGuid(), doctorName = "Dr. Smith", isReserved = false, cost = 100 }
            );
        }
    }
}
