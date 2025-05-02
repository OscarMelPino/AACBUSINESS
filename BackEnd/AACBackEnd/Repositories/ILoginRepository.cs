using AACBackEnd.Database.DBModels;
using AACBackEnd.Models;

namespace AACBackEnd.Repositories
{
    public interface ILoginRepository
    {
        Task<NewLogin?> GetLoginByUsernameAndPassword(string username, string password);
        Task<NewLogin?> GetLastUser();
    }
}
