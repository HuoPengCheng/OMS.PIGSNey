using System.Collections.Generic;
using OMS.PIGSNey.Roles.Dto;

namespace OMS.PIGSNey.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
