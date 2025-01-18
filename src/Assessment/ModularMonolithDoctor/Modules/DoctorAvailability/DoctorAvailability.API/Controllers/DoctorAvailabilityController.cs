using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DoctorAvailability.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorAvailabilityController : ControllerBase
    {
        private readonly ILogger<DoctorAvailabilityController> _logger;

        public DoctorAvailabilityController(ILogger<DoctorAvailabilityController> logger)
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
