using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TakeyourStand.MultiTenancy.Dto;

namespace TakeyourStand.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
