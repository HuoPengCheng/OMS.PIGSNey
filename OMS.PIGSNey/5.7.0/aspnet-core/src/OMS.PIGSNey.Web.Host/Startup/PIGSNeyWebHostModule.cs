using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OMS.PIGSNey.Configuration;

namespace OMS.PIGSNey.Web.Host.Startup
{
    [DependsOn(
       typeof(PIGSNeyWebCoreModule))]
    public class PIGSNeyWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PIGSNeyWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PIGSNeyWebHostModule).GetAssembly());
        }
    }
}
