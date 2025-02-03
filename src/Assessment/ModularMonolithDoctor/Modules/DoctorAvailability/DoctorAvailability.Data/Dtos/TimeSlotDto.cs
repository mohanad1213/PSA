using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAvailability.Data.Dtos
{
    public class TimeSlotDto
    {
        public Guid id { get; set; }
        public DateTime time { get; set; }
        public Guid doctorId { get; set; }
        public string doctorName { get; set; }
        public bool isReserved { get; set; }
        public decimal cost { get; set; }
    }
}
