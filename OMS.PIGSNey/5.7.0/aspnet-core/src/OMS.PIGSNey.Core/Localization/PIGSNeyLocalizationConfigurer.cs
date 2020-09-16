using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace OMS.PIGSNey.Localization
{
    public static class PIGSNeyLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PIGSNeyConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PIGSNeyLocalizationConfigurer).GetAssembly(),
                        "OMS.PIGSNey.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
