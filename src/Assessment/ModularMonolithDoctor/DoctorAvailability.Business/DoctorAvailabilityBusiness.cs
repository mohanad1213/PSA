using AutoMapper;
using DoctorAvailability.Business.Dtos;
using DoctorAvailability.Data.DataAcess;
using DoctorAvailability.Data.Database.Models;

namespace DoctorAvailability.Business
{
    public class DoctorAvailabilityBusiness
    {
        private readonly MapperConfiguration _config;
        private readonly IMapper _mapper;

        public DoctorAvailabilityBusiness()
        {
            _config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TimeSlot, TimeSlotModel>();
            });
            _mapper = _config.CreateMapper();
        }

        public List<TimeSlotModel> GetMyTimeSlots()
        {
            DoctorAvailabilityDataAccessLayer doctorAvailabilityDataAccessLayer = new DoctorAvailabilityDataAccessLayer();

            var result = doctorAvailabilityDataAccessLayer.GetMyTimeSlots();

            var timeSlotModels = _mapper.Map<List<TimeSlotModel>>(result);

            return timeSlotModels;
        }
    }
}
