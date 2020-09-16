using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OMS.PIGSNey.OMSAppli.Juristb.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.Juristb
{
    public interface IJuristb: ICrudAppService<JuristbDto,int, PagedAndSortedResultRequestDto, CreateUpdateJuristbDto>
    {
    }
}
