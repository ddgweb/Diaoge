using Diaoge.Configuration;
using Diaoge.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Diaoge.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class DiaogeDbContextFactory : IDesignTimeDbContextFactory<DiaogeDbContext>
    {
        public DiaogeDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DiaogeDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(DiaogeConsts.ConnectionStringName)
            );

            return new DiaogeDbContext(builder.Options);
        }
    }
}