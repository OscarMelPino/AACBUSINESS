using AACBackEnd.Database;
using AACBackEnd.Helpers;
using AACBackEnd.Models.Login;
using Microsoft.EntityFrameworkCore;

namespace AACBackEnd.Repositories.Login
{
    public class LoginRepository : ILoginRepository
    {

        // make it singleton    
        private readonly AppDbContext _context;
        public LoginRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<NewLogin?> GetLoginByUsernameAndPassword(string username, string password)
        {
            var user = await _context.AAC_USERS.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            if (user == null)
                return null;

            return new NewLogin { UserId = (uint)user.UserId, LastLogin = user.LastLogin, Username = user.Username };
        }

        public async Task<NewLogin?> GetLastUser()
        {
            var lastUser = await _context.AAC_USERS.OrderByDescending(user => user.UserId).FirstOrDefaultAsync();

            if (lastUser is null)
                return null;

            return new NewLogin { UserId = (uint)lastUser.UserId, LastLogin = lastUser.LastLogin, Username = lastUser.Username };

        }
    }
}
