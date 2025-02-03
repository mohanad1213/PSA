using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAvailability.Data.Dtos
{
    public class AddTimeSlotDto
    {
        public DateTime time { get; set; }
        public Guid doctorId { get; set; }
        public string doctorName { get; set; }
        public decimal cost { get; set; }
    }
}
