using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OMS.PIGSNey.EntityFrameworkCore;
using OMS.PIGSNey.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace OMS.PIGSNey.Web.Tests
{
    [DependsOn(
        typeof(PIGSNeyWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class PIGSNeyWebTestModule : AbpModule
    {
        public PIGSNeyWebTestModule(PIGSNeyEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PIGSNeyWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PIGSNeyWebMvcModule).Assembly);
        }
    }
}