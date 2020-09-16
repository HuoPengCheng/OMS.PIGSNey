using Abp.Authorization;
using OMS.PIGSNey.Authorization.Roles;
using OMS.PIGSNey.Authorization.Users;

namespace OMS.PIGSNey.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
