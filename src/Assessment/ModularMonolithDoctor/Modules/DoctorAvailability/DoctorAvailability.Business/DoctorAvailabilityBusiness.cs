//using Database;
//using DoctorAvailability.Business.Abstraction;
//using DoctorAvailability.Business.Dtos;
//using DoctorAvailability.Data;
//using DoctorAvailability.Data.Abstraction;

//namespace DoctorAvailability.Business
//{
//    public class DoctorAvailabilityBusiness : IDoctorAvailabilityBusiness
//    {
//        private readonly ITimeSlotRepo _timeSlotRepo;
//        public DoctorAvailabilityBusiness(ITimeSlotRepo timeSlotRepo)
//        {
//            _timeSlotRepo = timeSlotRepo;
//        }

//        public List<TimeSlotDto> GetMyTimeSlots()
//        {
//            List<TimeSlotDto> timeSlotDtos = new List<TimeSlotDto>();

//            // get from repo
//            var result = _timeSlotRepo.GetAllDoctorAvailabilityTimeSlot();

//            // map db to dto 
//            foreach (var item in result)
//            {
//                timeSlotDtos.Add(
//                    TimeSlotDto.Create(
//                    item.id,
//                    item.time,
//                    item.doctorId,
//                    item.doctorName,
//                    item.cost));

//            }

//            return timeSlotDtos;
//        }
//    }
//}
