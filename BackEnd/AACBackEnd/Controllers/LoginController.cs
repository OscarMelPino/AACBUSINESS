using AACBackEnd.Database.DBModels;
using AACBackEnd.Models;
using AACBackEnd.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AACBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ILoginRepository _loginRepository;
        Managers.LoginManager _loginManager;

        public LoginController(ILogger<LoginController> _logger, ILoginRepository loginRepository)
        {
            this._logger = _logger;
            _loginRepository = loginRepository;
            this._loginManager = new Managers.LoginManager(_loginRepository);
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
