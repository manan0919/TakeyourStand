using System.Collections.Generic;
using TakeyourStand.Roles.Dto;
using TakeyourStand.Users.Dto;

namespace TakeyourStand.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}