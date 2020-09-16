using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace OMS.PIGSNey.Web.Views
{
    public abstract class PIGSNeyRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PIGSNeyRazorPage()
        {
            LocalizationSourceName = PIGSNeyConsts.LocalizationSourceName;
        }
    }
}
