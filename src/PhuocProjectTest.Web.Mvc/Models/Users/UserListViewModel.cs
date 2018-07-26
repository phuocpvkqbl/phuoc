using System.Collections.Generic;
using PhuocProjectTest.Roles.Dto;
using PhuocProjectTest.Users.Dto;

namespace PhuocProjectTest.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
