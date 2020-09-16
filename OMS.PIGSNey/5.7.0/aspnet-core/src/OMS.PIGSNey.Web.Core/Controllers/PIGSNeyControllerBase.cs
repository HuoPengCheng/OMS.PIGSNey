using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace OMS.PIGSNey.Controllers
{
    public abstract class PIGSNeyControllerBase: AbpController
    {
        protected PIGSNeyControllerBase()
        {
            LocalizationSourceName = PIGSNeyConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
