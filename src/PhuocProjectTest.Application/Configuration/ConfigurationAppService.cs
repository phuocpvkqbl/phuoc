using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PhuocProjectTest.Configuration.Dto;

namespace PhuocProjectTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PhuocProjectTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
