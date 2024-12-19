using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace OnionAPI.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// API: POST Auth/Login
        /// </summary>
        /// <returns></returns>
        [HttpPost(Name = "Login")]
        public IActionResult Login(LoginRequest loginRequest)
        {
            return Ok();
        }

        /// <summary>
        /// API: GET Auth/Logout
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Logout")]
        public IActionResult Logout()
        {
            return Ok();
        }
    }
}
