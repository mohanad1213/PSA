using Microsoft.AspNetCore.Mvc;
using StudentAPI.Presentation.RequestModel;

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

        [HttpPost(Name = "Register")]
        public IEnumerable<Object> Register(AddStudentRequest addStudentRequest)
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
