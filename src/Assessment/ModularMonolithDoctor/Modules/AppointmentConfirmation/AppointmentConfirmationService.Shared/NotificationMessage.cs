using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentConfirmationService.Shared
{
    public class NotificationMessage
    {
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime Time { get; set; }
    }
}
