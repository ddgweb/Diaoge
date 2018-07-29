using Microsoft.EntityFrameworkCore;

namespace Diaoge.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<DiaogeDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for DiaogeDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
