using System.Threading.Tasks;
using Abp.Application.Services;
using TakeyourStand.Sessions.Dto;

namespace TakeyourStand.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
