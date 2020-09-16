using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OMS.PIGSNey.Authorization;

namespace OMS.PIGSNey
{
    [DependsOn(
        typeof(PIGSNeyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PIGSNeyApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PIGSNeyAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PIGSNeyApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
