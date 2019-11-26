using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using maxwell.MyABP.Configuration.Dto;

namespace maxwell.MyABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
