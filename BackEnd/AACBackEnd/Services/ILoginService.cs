using AACBackEnd.Models;

namespace AACBackEnd.Services
{
    public interface ILoginService
    {
        LoginModel? GetLoginByUsernameAndPassword(string username, string password);
    }
}
