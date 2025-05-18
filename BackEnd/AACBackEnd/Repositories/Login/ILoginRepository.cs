using AACBackEnd.Database.DBModels;
using AACBackEnd.Models.Login;

namespace AACBackEnd.Repositories.Login
{
    public interface ILoginRepository
    {
        Task<NewLogin?> GetLoginByUsernameAndPassword(string username, string password);
        Task<NewLogin?> GetLastUser();
    }
}
