using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppointmentBooking.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentBookingController : ControllerBase
    {
        private readonly ILogger<AppointmentBookingController> _logger;

        public AppointmentBookingController(ILogger<AppointmentBookingController> logger)
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
