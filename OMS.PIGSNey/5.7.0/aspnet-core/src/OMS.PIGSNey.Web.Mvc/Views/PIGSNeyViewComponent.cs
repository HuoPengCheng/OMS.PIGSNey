using Abp.AspNetCore.Mvc.ViewComponents;

namespace OMS.PIGSNey.Web.Views
{
    public abstract class PIGSNeyViewComponent : AbpViewComponent
    {
        protected PIGSNeyViewComponent()
        {
            LocalizationSourceName = PIGSNeyConsts.LocalizationSourceName;
        }
    }
}
