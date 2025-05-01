using AACBackEnd.Models;
using AACBackEnd.Services;

namespace AACBackEnd.Managers
{
    public class LoginManager : BaseManager
    {
        private readonly ILoginService _loginService;

        public LoginManager(ILoginService loginService)
        {
            this._loginService = loginService;
        }

        // methods
        public LoginModel ValidateLogin(LoginRequest credentials)
        {
            // find in database based on username and password            
            return this._loginService.GetLoginByUsernameAndPassword(credentials.Username, credentials.Password);
        }
    }
}
