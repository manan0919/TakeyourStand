using System.Collections.Generic;
using TakeyourStand.Roles.Dto;

namespace TakeyourStand.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}