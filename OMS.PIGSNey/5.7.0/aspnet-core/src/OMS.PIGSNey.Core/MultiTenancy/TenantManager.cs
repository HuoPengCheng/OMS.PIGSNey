using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using OMS.PIGSNey.Authorization.Users;
using OMS.PIGSNey.Editions;

namespace OMS.PIGSNey.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
