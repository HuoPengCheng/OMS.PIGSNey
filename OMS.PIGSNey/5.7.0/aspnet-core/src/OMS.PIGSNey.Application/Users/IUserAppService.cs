using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OMS.PIGSNey.Roles.Dto;
using OMS.PIGSNey.Users.Dto;

namespace OMS.PIGSNey.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
