using System.Collections.Generic;
using maxwell.MyABP.Roles.Dto;

namespace maxwell.MyABP.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
