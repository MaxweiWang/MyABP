using Abp.Authorization;
using maxwell.MyABP.Authorization.Roles;
using maxwell.MyABP.Authorization.Users;

namespace maxwell.MyABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
