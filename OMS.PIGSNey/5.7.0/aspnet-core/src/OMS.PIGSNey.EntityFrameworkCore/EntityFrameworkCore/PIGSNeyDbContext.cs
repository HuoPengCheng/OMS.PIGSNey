using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OMS.PIGSNey.Authorization.Roles;
using OMS.PIGSNey.Authorization.Users;
using OMS.PIGSNey.MultiTenancy;
using OMS.PIGSNey.Models;

namespace OMS.PIGSNey.EntityFrameworkCore
{
    public class PIGSNeyDbContext : AbpZeroDbContext<Tenant, Role, User, PIGSNeyDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PIGSNeyDbContext(DbContextOptions<PIGSNeyDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplyFortb> ApplyFortb { get; set; }
        public DbSet<CommodityDetailstb> CommodityDetailstb { get; set; }
        public DbSet<Complaintb> Complaintb { get; set; }
        public DbSet<Juristb> Juristb { get; set; }
        public DbSet<MaintenanceDetailstb> MaintenanceDetailstb { get; set; }
        public DbSet<Materialstb> Materialstb { get; set; }
        public DbSet<Purchasetb> Purchasetb { get; set; }
        public DbSet<Questiontb> Questiontb { get; set; }
        public DbSet<RealNametb> RealNametb { get; set; }
        public DbSet<Roletb> Roletb { get; set; }
        public DbSet<Tooltb> Tooltb { get; set; }
        public DbSet<UserInfotb> UserInfotb { get; set; }
        public DbSet<UserRepairsDetailstb> UserRepairsDetailstb { get; set; }
        public DbSet<UserSubsidiarytb> UserSubsidiarytb { get; set; }
    }
}
