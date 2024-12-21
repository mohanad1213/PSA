using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using OnionAPI.Application.Abstractions.ServicesContract;

namespace OnionAPI.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AuthController : ControllerBase
    {
        #region Private && Constructor
        private readonly ILogger<AuthController> _logger;
        private readonly IAuthService _authService;

        public AuthController(
            ILogger<AuthController> logger,
            IAuthService authService
            )
        {
            _logger = logger;
            _authService = authService;
        }
        #endregion

        #region End-Points
        /// <summary>
        /// API: POST Auth/Login
        /// </summary>
        /// <returns></returns>
        [HttpPost(Name = "Login")]
        public IActionResult Login(LoginRequest loginRequest)
        {
            this._authService.Login();
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
        #endregion
    }
}
