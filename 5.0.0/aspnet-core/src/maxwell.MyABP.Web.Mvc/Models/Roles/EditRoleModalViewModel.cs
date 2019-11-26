using Abp.AutoMapper;
using maxwell.MyABP.Roles.Dto;
using maxwell.MyABP.Web.Models.Common;

namespace maxwell.MyABP.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
