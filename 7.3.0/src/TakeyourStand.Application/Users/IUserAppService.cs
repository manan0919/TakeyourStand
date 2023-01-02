using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TakeyourStand.Roles.Dto;
using TakeyourStand.Users.Dto;

namespace TakeyourStand.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}