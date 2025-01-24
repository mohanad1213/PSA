using DoctorAppointmentManagement.API.Core.Application.Abstractions;
using DoctorAppointmentManagement.API.Core.Ports.InputPorts.RepoAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentManagement.API.Core.Services
{
    public class SlotService : ISlotService
    {
        private readonly IRepo _repo;

        public SlotService(
            IRepo repo
            )
        {
            _repo = repo;
        }
    }
}
