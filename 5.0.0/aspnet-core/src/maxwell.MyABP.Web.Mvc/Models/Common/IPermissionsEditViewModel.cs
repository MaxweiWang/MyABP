using System.Collections.Generic;
using maxwell.MyABP.Roles.Dto;

namespace maxwell.MyABP.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}