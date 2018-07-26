using Abp.Authorization;
using PhuocProjectTest.Authorization.Roles;
using PhuocProjectTest.Authorization.Users;

namespace PhuocProjectTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
