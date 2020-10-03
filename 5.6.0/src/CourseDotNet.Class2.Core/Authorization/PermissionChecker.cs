using Abp.Authorization;
using CourseDotNet.Class2.Authorization.Roles;
using CourseDotNet.Class2.Authorization.Users;

namespace CourseDotNet.Class2.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
