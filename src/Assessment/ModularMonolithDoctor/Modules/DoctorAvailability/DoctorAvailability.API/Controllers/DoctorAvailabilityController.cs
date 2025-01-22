using AutoMapper;
using Database;
using DoctorAvailability.Business;
using DoctorAvailability.Business.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DoctorAvailability.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorAvailabilityController : ControllerBase
    {
        private readonly ILogger<DoctorAvailabilityController> _logger;
        private readonly DocktorDbContext _appDbContext;
        private readonly DoctorAvailabilityBusiness doctorAvailabilityBusiness;

        public DoctorAvailabilityController(
            DocktorDbContext appContext,
            ILogger<DoctorAvailabilityController> logger
            )
        {
            _logger = logger;
            this.doctorAvailabilityBusiness = new DoctorAvailabilityBusiness(appContext);
        }

        [HttpGet()]
        public ActionResult<List<TimeSlotDto>> Get()
        {
            var doctorTimeSlotList = doctorAvailabilityBusiness.GetMyTimeSlots();

            return Ok(doctorTimeSlotList);
        }


        [HttpPost()]
        public ActionResult Post()
        {
            return Ok();
        }
    }
}
