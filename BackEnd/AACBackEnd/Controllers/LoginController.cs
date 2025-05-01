using AACBackEnd.Models;
using AACBackEnd.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AACBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ILoginService _loginService;
        Managers.LoginManager _loginManager;

        public LoginController(ILogger<LoginController> _logger, ILoginService loginService)
        {
            this._logger = _logger;
            _loginService = loginService;
            this._loginManager = new Managers.LoginManager(_loginService);
        }

        // GET: api/<ItemsController>
        [HttpPost]
        public LoginModel? Post([FromBody] LoginRequest newLogin)
        {
            return this._loginManager.ValidateLogin(newLogin);
        }

    }
}
