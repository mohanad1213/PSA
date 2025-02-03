using DoctorAvailability.Business.Abstraction;
using DoctorAvailability.Data;
using DoctorAvailability.Data.Abstraction;
using DoctorAvailability.Data.Dtos;

namespace DoctorAvailability.Business
{
    public class DoctorAvailabilityBusiness : IDoctorAvailabilityBusiness
    {
        private readonly ITimeSlotRepo _timeSlotRepo;
        public DoctorAvailabilityBusiness(ITimeSlotRepo timeSlotRepo)
        {
            _timeSlotRepo = timeSlotRepo;
        }

        public List<TimeSlotDto> AddNewTimeSlot(AddTimeSlotDto addTimeSlotDto)
        {
            var result = _timeSlotRepo.AddNewTimeSlot(addTimeSlotDto);

            var resultList = _timeSlotRepo.GetAllDoctorAvailabilityTimeSlot();

            return resultList;
        }

       

        public List<TimeSlotDto> GetMyTimeSlots()
        {
            List<TimeSlotDto> timeSlotDtos = new List<TimeSlotDto>();

            // get from repo
            var result = _timeSlotRepo.GetAllDoctorAvailabilityTimeSlot();

            // map db to dto 
            foreach (var item in result)
            {
                timeSlotDtos.Add(new TimeSlotDto()
                {
                    id = item.id,
                    time = item.time,
                    doctorId = item.doctorId,
                    doctorName = item.doctorName,
                    isReserved = item.isReserved,
                    cost = item.cost
                });
            }

            return timeSlotDtos;
        }
    }
}
