using AACBackEnd.Database.DBModels;
using AACBackEnd.Managers;
using AACBackEnd.Models.Login;
using AACBackEnd.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AACBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        Managers.LoginManager _loginManager;

        public LoginController(ILogger<LoginController> _logger,LoginManager loginManager)
        {
            this._logger = _logger;
            this._loginManager = loginManager;
        }

        [HttpGet]
        public async Task<NewLogin?>? Get()
        {
            return await this._loginManager.GetTestUser();
        }

        // GET: api/<ItemsController>
        [HttpPost]
        public async Task<NewLogin?>? Post([FromBody] LoginRequest newLogin)
        {
            return await this._loginManager.ValidateLogin(newLogin);
        }

    }
}
