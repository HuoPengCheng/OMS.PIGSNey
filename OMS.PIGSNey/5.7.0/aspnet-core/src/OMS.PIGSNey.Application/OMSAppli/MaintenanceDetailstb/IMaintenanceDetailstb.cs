using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OMS.PIGSNey.OMSAppli.Juristb.Dto;
using OMS.PIGSNey.OMSAppli.MaintenanceDetailstb.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.MaintenanceDetailstb
{
    public interface IMaintenanceDetailstb: ICrudAppService<MaintenanceDetailstbDto,int, PagedAndSortedResultRequestDto, CreateUpdateMaintenanceDetailstbDto>
    {
    }
}
