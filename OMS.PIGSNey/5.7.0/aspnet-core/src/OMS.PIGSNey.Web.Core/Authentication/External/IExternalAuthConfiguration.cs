using System.Collections.Generic;

namespace OMS.PIGSNey.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
