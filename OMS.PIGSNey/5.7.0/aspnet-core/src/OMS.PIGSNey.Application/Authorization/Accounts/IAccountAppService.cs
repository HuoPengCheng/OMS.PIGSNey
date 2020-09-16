using System.Threading.Tasks;
using Abp.Application.Services;
using OMS.PIGSNey.Authorization.Accounts.Dto;

namespace OMS.PIGSNey.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
