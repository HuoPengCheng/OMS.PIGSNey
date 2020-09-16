using System.Threading.Tasks;
using OMS.PIGSNey.Configuration.Dto;

namespace OMS.PIGSNey.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
