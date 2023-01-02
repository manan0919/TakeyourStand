using System.Threading.Tasks;
using Abp.Application.Services;
using TakeyourStand.Authorization.Accounts.Dto;

namespace TakeyourStand.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
