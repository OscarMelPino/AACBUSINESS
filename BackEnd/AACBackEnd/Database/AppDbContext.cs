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
        public DbSet<AAC_ITEMS> AAC_ITEMS { get; set; }
        public DbSet<AAC_RECIPES> AAC_RECIPES { get; set; }
        public DbSet<AAC_ATTACKERPROFILE> AAC_ATTACKERPROFILE { get; set; }
    }

}
