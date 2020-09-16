using Abp.MultiTenancy;
using OMS.PIGSNey.Authorization.Users;

namespace OMS.PIGSNey.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
