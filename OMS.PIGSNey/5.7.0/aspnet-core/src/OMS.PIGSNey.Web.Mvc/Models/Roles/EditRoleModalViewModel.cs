using Abp.AutoMapper;
using OMS.PIGSNey.Roles.Dto;
using OMS.PIGSNey.Web.Models.Common;

namespace OMS.PIGSNey.Web.Models.Roles
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
