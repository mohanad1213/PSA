using AutoMapper;
using DoctorAvailability.Business;
using DoctorAvailability.Business.Abstraction;
using DoctorAvailability.Data.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DoctorAvailability.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorAvailabilityController : ControllerBase
    {
        private readonly ILogger<DoctorAvailabilityController> _logger;
        private readonly IDoctorAvailabilityBusiness _doctorAvailabilityBusiness;

        public DoctorAvailabilityController(
            IDoctorAvailabilityBusiness doctorAvailabilityBusiness,
            ILogger<DoctorAvailabilityController> logger
            )
        {
            _logger = logger;
            this._doctorAvailabilityBusiness = doctorAvailabilityBusiness;
        }

        [HttpGet()]
        public ActionResult<List<TimeSlotDto>> Get()
        {
            var doctorTimeSlotList = _doctorAvailabilityBusiness.GetMyTimeSlots();

            return Ok(doctorTimeSlotList);
        }


        [HttpPost()]
        public ActionResult AddNewSlot(AddTimeSlotDto addTimeSlotDto)
        {
            var doctorTimeSlotList = _doctorAvailabilityBusiness.AddNewTimeSlot(addTimeSlotDto);

            return Ok(doctorTimeSlotList);
        }
    }
}
