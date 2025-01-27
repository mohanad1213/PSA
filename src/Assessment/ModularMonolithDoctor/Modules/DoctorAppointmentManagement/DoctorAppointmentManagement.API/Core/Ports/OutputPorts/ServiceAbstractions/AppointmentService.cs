using DoctorAppointmentManagement.API.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentManagement.API.Core.Ports.OutputPorts.ServiceAbstractions
{
    public interface IAppointmentService 
    {
        public int Do(Commands.Command command);
        public ResponceModel Do2(Commands.Command command);
    }
}
