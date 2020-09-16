using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OMS.PIGSNey.Configuration;

namespace OMS.PIGSNey.Web.Startup
{
    [DependsOn(typeof(PIGSNeyWebCoreModule))]
    public class PIGSNeyWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PIGSNeyWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<PIGSNeyNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PIGSNeyWebMvcModule).GetAssembly());
        }
    }
}
