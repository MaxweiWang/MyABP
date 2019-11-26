using System.Collections.Generic;
using maxwell.MyABP.Roles.Dto;
using maxwell.MyABP.Users.Dto;

namespace maxwell.MyABP.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
