using System.Collections.Generic;
using OMS.PIGSNey.Roles.Dto;

namespace OMS.PIGSNey.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
