using DoctorAppointmentManagement.API.Core.Commands;
using DoctorAppointmentManagement.API.Core.Models;
using DoctorAppointmentManagement.API.Core.Ports.OutputPorts.ServiceAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentManagement.API.Core.Services
{
    public class AppointmentService : IAppointmentService
    {
        //private readonly object _Obj;
        public int Do(Command command)
        {
            return command.num;
        }

        public ResponceModel Do2(Command command)
        {
            ResponceModel responceModel = new ResponceModel();

            return responceModel;
        }
    }
}
