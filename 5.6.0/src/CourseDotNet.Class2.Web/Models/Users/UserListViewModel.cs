using System.Collections.Generic;
using CourseDotNet.Class2.Roles.Dto;
using CourseDotNet.Class2.Users.Dto;

namespace CourseDotNet.Class2.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}