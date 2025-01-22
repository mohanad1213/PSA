using DoctorAvailability.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAvailability.Business.Abstraction
{
    public interface IDoctorAvailabilityBusiness
    {
        public List<TimeSlotDto> GetMyTimeSlots();
    }
}
