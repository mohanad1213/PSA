using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DoctorAppointmentManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentManagementController : ControllerBase
    {
        private readonly ILogger<AppointmentManagementController> _logger;

        public AppointmentManagementController(ILogger<AppointmentManagementController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
