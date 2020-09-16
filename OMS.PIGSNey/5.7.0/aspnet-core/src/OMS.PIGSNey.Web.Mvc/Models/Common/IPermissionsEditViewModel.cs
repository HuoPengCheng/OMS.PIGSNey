using System.Collections.Generic;
using OMS.PIGSNey.Roles.Dto;

namespace OMS.PIGSNey.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}