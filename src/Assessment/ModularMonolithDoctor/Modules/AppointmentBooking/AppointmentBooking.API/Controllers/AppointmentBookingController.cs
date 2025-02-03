using AppointmentBooking.Application.ServicesAbstraction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppointmentBooking.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentBookingController : ControllerBase
    {
        #region Private && Constructor 
        private readonly ILogger<AppointmentBookingController> _logger;
        private readonly IAppointmentBookingService _appointmentBookingService;

        public AppointmentBookingController(
            IAppointmentBookingService appointmentBookingService,
            ILogger<AppointmentBookingController> logger
            )
        {
            this._appointmentBookingService = appointmentBookingService;
            _logger = logger;
        }
        #endregion

        [HttpPost()]
        public IActionResult Get()
        {
            _appointmentBookingService.MyBooking();
            return Ok();
        }
    }
}
