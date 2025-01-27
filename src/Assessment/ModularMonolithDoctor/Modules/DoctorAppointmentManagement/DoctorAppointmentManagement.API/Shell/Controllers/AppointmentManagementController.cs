using DoctorAppointmentManagement.API.Core.Application.Abstractions;
using DoctorAppointmentManagement.API.Core.Ports.OutputPorts.ServiceAbstractions;
using DoctorAppointmentManagement.API.Shell.Requests;
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

        [HttpGet("{NumRequest}")]
        public IActionResult Get(int NumRequest)
        {
            Core.Commands.Command command = new Core.Commands.Command();
            var result = _appointmentService.Do(command);
            return Ok();
        }
    }
}
