using Abp.AutoMapper;
using OMS.PIGSNey.Sessions.Dto;

namespace OMS.PIGSNey.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
