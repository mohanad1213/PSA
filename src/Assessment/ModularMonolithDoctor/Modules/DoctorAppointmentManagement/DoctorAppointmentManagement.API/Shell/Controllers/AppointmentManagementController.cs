using DoctorAppointmentManagement.API.Core.Application.Abstractions;
using DoctorAppointmentManagement.API.Core.Ports.OutputPorts.ServiceAbstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DoctorAppointmentManagement.API.Shell.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentManagementController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly ISlotService _slotService ;
        private readonly ILogger<AppointmentManagementController> _logger;
     

        public AppointmentManagementController(
            IAppointmentService appointmentService,
            ISlotService slotService,
            ILogger<AppointmentManagementController> logger
            )
        {
            this._appointmentService = appointmentService;
            this._slotService = slotService;
            _logger = logger;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
