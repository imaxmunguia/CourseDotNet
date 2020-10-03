using System.Collections.Generic;
using CourseDotNet.Class2.Roles.Dto;

namespace CourseDotNet.Class2.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}