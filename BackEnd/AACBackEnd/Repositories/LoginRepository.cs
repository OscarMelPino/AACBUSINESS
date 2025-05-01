using AACBackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace AACBackEnd.Repositories
{
    public class LoginRepository : DbContext
    {

        public LoginRepository() { }

        public LoginRepository(DbContextOptions<LoginRepository> options) : base(options)
        {
        }

        public static DbSet<LoginModel> Logins { get; set; } = null!;
    }
}
