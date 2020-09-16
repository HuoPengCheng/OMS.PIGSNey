using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using OMS.PIGSNey.Configuration.Dto;

namespace OMS.PIGSNey.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PIGSNeyAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
