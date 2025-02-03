using DoctorAvailability.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAvailability.Data.Abstraction
{
    public interface ITimeSlotRepo
    {
        public List<TimeSlotDto> GetAllDoctorAvailabilityTimeSlot();

        public List<TimeSlotDto> AddNewTimeSlot(AddTimeSlotDto addTimeSlotDto);
    }
}
