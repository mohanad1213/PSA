using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppointmentBooking.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SlotsController : ControllerBase
    {
        private readonly ILogger<SlotsController> _logger;

        public SlotsController(ILogger<SlotsController> logger)
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
