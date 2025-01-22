using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAvailability.Business.Dtos
{
    public class TimeSlotDto
    {
        private Guid id;
        private DateTime time;
        private Guid doctorId;
        private string doctorName;
        private bool isReserved;
        private decimal cost;



        // Constructor
        private TimeSlotDto(Guid id, DateTime time, Guid doctorId, string doctorName, decimal cost)
        {
            if (time <= DateTime.Now)
                throw new ArgumentException("Appointment time must be in the future.");

            if (string.IsNullOrWhiteSpace(doctorName))
                throw new ArgumentException("Doctor name cannot be empty.");

            if (cost <= 0)
                throw new ArgumentException("Cost must be greater than zero.");

            id = id;
            time = time;
            doctorId = doctorId;
            doctorName = doctorName;
            cost = cost;
            isReserved = false; // Default to not reserved
        }

        public static TimeSlotDto Create(Guid id, DateTime time, Guid doctorId, string doctorName, decimal cost)
        {
            return new TimeSlotDto(id, time, doctorId, doctorName, cost);
        }
    }
}
