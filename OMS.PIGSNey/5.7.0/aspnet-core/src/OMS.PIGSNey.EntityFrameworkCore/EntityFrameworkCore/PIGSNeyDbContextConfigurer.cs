using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace OMS.PIGSNey.EntityFrameworkCore
{
    public static class PIGSNeyDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PIGSNeyDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PIGSNeyDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
