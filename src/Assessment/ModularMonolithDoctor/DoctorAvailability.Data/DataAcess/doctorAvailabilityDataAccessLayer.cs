using DoctorAvailability.Data.Database.Models;

namespace DoctorAvailability.Data.DataAcess
{
    public class DoctorAvailabilityDataAccessLayer
    {
        public List<TimeSlot> GetMyTimeSlots()
        {
            return new List<TimeSlot>
            {
                new TimeSlot { Id = Guid.NewGuid(), Time = DateTime.Now.AddHours(1), DoctorName = "Dr. Smith", DoctorId = Guid.NewGuid(), IsReserved = false, Cost = 100m },
                new TimeSlot { Id = Guid.NewGuid(), Time = DateTime.Now.AddHours(2), DoctorName = "Dr. Johnson", DoctorId = Guid.NewGuid(), IsReserved = false, Cost = 150m },
                new TimeSlot { Id = Guid.NewGuid(), Time = DateTime.Now.AddHours(3), DoctorName = "Dr. Williams", DoctorId = Guid.NewGuid(), IsReserved = false, Cost = 200m },
                new TimeSlot { Id = Guid.NewGuid(), Time = DateTime.Now.AddHours(4), DoctorName = "Dr. Brown", DoctorId = Guid.NewGuid(), IsReserved = false, Cost = 250m },
                new TimeSlot { Id = Guid.NewGuid(), Time = DateTime.Now.AddHours(5), DoctorName = "Dr. Jones", DoctorId = Guid.NewGuid(), IsReserved = false, Cost = 300m }
            };
        }
    }
}
