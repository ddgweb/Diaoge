using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Diaoge.EntityFrameworkCore
{
    public class DiaogeDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public DiaogeDbContext(DbContextOptions<DiaogeDbContext> options) 
            : base(options)
        {

        }
    }
}
