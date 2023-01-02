using Abp.Authorization;
using TakeyourStand.Authorization.Roles;
using TakeyourStand.Authorization.Users;

namespace TakeyourStand.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
