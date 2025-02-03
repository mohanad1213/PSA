using In_MemoryDB.DB1.Tables;
using Microsoft.EntityFrameworkCore;

namespace In_MemoryDB.DB1
{
    public class InMemoryDB1: DbContext
    {
        public InMemoryDB1(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<TimeSlot> timeSlots { get; set; }
        //public virtual DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
