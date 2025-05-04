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
        public async Task<NewLogin?> ValidateLogin(LoginRequest credentials)
        {
            return await this._loginService.GetLoginByUsernameAndPassword(credentials.Username, credentials.Password);
        }

        public async Task<NewLogin?> GetTestUser()
        {
            return await this._loginService.GetLastUser();
        }
    }
}
