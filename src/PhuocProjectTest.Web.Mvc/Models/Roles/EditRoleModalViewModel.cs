using System.Collections.Generic;
using System.Linq;
using PhuocProjectTest.Roles.Dto;

namespace PhuocProjectTest.Web.Models.Roles
{
    public class EditNewsModalViewModel
    {
        public RoleDto Role { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }

        public bool HasPermission(PermissionDto permission)
        {
            return Permissions != null && Role.Permissions.Any(p => p == permission.Name);
        }
    }
}
