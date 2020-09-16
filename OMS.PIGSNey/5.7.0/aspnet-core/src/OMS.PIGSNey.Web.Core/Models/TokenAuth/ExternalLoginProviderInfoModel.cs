using Abp.AutoMapper;
using OMS.PIGSNey.Authentication.External;

namespace OMS.PIGSNey.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
