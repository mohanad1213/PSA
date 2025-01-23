using AppointmentBooking.Application.ServicesAbstraction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppointmentBooking.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SlotsController : ControllerBase
    {
        #region Private && Constructor 
        private readonly ILogger<SlotsController> _logger;
        private readonly IAppointmentBookingService _appointmentBookingService;

        public SlotsController(
            IAppointmentBookingService appointmentBookingService,
            ILogger<SlotsController> logger
            )
        {
            this._appointmentBookingService = appointmentBookingService;
            _logger = logger;
        }
        #endregion

        #region End-Points
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(this._appointmentBookingService.MyBooking());
        }
        #endregion
    }
}
