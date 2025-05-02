using AACBackEnd.Database.DBModels;
using AACBackEnd.Models;
using AACBackEnd.Repositories;

namespace AACBackEnd.Managers
{
    public class LoginManager : BaseManager
    {
        private readonly ILoginRepository _loginService;

        public LoginManager(ILoginRepository loginService)
        {
            this._loginService = loginService;
        }

        // methods
        public Task<NewLogin?> ValidateLogin(LoginRequest credentials)
        {
            return this._loginService.GetLoginByUsernameAndPassword(credentials.Username, credentials.Password);
        }

        public Task<NewLogin?> GetTestUser()
        {
            return this._loginService.GetLastUser();
        }
    }
}
