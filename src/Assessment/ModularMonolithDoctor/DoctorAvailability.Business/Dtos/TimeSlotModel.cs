using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAvailability.Business.Dtos
{
    public class TimeSlotModel
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public string DoctorName { get; set; }
        public Guid DoctorId { get; set; }
        public bool IsReserved { get; set; }

        public decimal Cost { get; set; }
    }
}
