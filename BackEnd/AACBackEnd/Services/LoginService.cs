using AACBackEnd.Models;
using AACBackEnd.Repositories;

namespace AACBackEnd.Services
{
    public class LoginService : ILoginService
    {

        // make it singleton    
        private static readonly Lazy<LoginService> _instance = new Lazy<LoginService>(() => new LoginService());

        public LoginService() { }

        public LoginModel? GetLoginByUsernameAndPassword(string username, string password)
        {
#if DEBUG
            if (username == "admin" && password == "1234")
            {
                return new LoginModel
                {
                    UserId = 1,
                    Username = "admin",
                    LastLogin = DateTime.Now.ToString()
                };
            }
            return null;
#endif
            if (LoginRepository.Logins.Any(logins => logins.Username == username && logins.Password == password))
            {
                // find in database based on username and password            
                LoginModel? login = LoginRepository.Logins.FirstOrDefault(logins => logins.Username == username && logins.Password == password);
                // if found, return true
                if (login != null)
                {
                    // set the user id
                    login.UserId = login.UserId;
                    // set the last login
                    login.LastLogin = DateTime.Now.ToString();
                    return login;
                }
            }
            return null;
        }
    }
}
