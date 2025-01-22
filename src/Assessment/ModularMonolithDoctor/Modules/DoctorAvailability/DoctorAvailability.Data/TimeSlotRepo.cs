using Database;
using Database.Models;
using DoctorAvailability.Data.Abstraction;

namespace DoctorAvailability.Data
{
    public class TimeSlotRepo : ITimeSlotRepo
    {
        private readonly DocktorDbContext _appDbContext;
        public TimeSlotRepo(DocktorDbContext appContext)
        {
            this._appDbContext = appContext;
        }


        public List<TimeSlot> GetAllDoctorAvailabilityTimeSlot()
        {
            return this._appDbContext.timeSlots.ToList();
        }
    }
}
