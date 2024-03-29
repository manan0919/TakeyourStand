﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TakeyourStand.Configuration.Dto;

namespace TakeyourStand.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TakeyourStandAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
