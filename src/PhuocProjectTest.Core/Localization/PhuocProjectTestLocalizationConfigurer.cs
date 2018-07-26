using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PhuocProjectTest.Localization
{
    public static class PhuocProjectTestLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PhuocProjectTestConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PhuocProjectTestLocalizationConfigurer).GetAssembly(),
                        "PhuocProjectTest.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
