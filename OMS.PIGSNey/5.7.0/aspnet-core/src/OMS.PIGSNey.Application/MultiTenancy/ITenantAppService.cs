using Abp.Application.Services;
using OMS.PIGSNey.MultiTenancy.Dto;

namespace OMS.PIGSNey.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

