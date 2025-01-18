using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppointmentConfirmation.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentConfirmationController : ControllerBase
    {
        private readonly ILogger<AppointmentConfirmationController> _logger;

        public AppointmentConfirmationController(ILogger<AppointmentConfirmationController> logger)
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
