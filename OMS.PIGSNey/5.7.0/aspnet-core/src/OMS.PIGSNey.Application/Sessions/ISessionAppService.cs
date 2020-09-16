using System.Threading.Tasks;
using Abp.Application.Services;
using OMS.PIGSNey.Sessions.Dto;

namespace OMS.PIGSNey.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
