using Database;
using DoctorAvailability.Business.Dtos;
using DoctorAvailability.Data;

namespace DoctorAvailability.Business
{
    public class DoctorAvailabilityBusiness
    {
        private readonly TimeSlotRepo _timeSlotRepo;
        public DoctorAvailabilityBusiness(DocktorDbContext appContext)
        {
            _timeSlotRepo = new TimeSlotRepo(appContext);
        }

        public List<TimeSlotDto> GetMyTimeSlots()
        {
            List<TimeSlotDto> timeSlotDtos = new List<TimeSlotDto>();

            // get from repo
            var result = _timeSlotRepo.GetAllDoctorAvailabilityTimeSlot();

            // map db to dto 
            foreach (var item in result)
            {
                timeSlotDtos.Add(
                    TimeSlotDto.Create(
                    item.id,
                    item.time,
                    item.doctorId,
                    item.doctorName,
                    item.cost));

            }

            return timeSlotDtos;
        }
    }
}
