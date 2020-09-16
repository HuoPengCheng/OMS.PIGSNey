using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using OMS.PIGSNey.Configuration;
using OMS.PIGSNey.Web;

namespace OMS.PIGSNey.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PIGSNeyDbContextFactory : IDesignTimeDbContextFactory<PIGSNeyDbContext>
    {
        public PIGSNeyDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PIGSNeyDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PIGSNeyDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PIGSNeyConsts.ConnectionStringName));

            return new PIGSNeyDbContext(builder.Options);
        }
    }
}
