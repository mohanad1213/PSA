using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Register")]
        public IEnumerable<Object> Register()
        {
            return null;
        }

        [HttpGet(Name = "List")]
        public IEnumerable<Object> List()
        {
            return null;
        }
    }
}
