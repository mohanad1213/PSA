using AutoMapper;
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

        public DoctorAvailabilityController(ILogger<DoctorAvailabilityController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public ActionResult<List<TimeSlotModel>> Get()
        {
            DoctorAvailabilityBusiness doctorAvailabilityBusiness = new DoctorAvailabilityBusiness();
            var doctorTimeSlotList = doctorAvailabilityBusiness.GetMyTimeSlots();




            return Ok(doctorTimeSlotList);
        }


        [HttpPost()]
        public ActionResult Post()
        {
            DoctorAvailabilityBusiness doctorAvailabilityBusiness = new DoctorAvailabilityBusiness();

            return Ok();
        }
    }
}
