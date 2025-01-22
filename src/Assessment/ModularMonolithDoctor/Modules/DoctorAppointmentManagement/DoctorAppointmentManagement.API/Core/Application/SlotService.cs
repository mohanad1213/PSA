using DoctorAppointmentManagement.API.Core.InputPorts.RepoAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentManagement.API.Core.Application
{
    public class SlotService
    {
        private readonly IRepo _repo;

        public SlotService(
            IRepo repo
            )
        {
            this._repo = repo;
        }
    }
}
