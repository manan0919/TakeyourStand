using System.Threading.Tasks;
using Abp.Application.Services;
using TakeyourStand.Configuration.Dto;

namespace TakeyourStand.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}