using AACBackEnd.Database.DBModels;
using Microsoft.EntityFrameworkCore;

namespace AACBackEnd.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<AAC_USERS> AAC_USERS { get; set; }
    }

}
