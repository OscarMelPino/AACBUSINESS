using AACBackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AACBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> _logger)
        {
            this._logger = _logger;
        }

        // GET: api/<ItemsController>
        [HttpGet]
        public LoginModel Get()
        {
            var deutan = new LoginModel() { Name = "Deutan" };
            return deutan;
        }

    }
}
