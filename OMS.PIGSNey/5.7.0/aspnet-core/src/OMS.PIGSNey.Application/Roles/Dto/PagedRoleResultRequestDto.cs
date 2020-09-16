using Abp.Application.Services.Dto;

namespace OMS.PIGSNey.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

