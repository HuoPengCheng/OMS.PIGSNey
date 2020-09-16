using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OMS.PIGSNey.OMSAppli.ApplyFortb.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.ApplyFortb
{
   public interface IApplyFortb : ICrudAppService<ApplyFortbDto,int, PagedAndSortedResultRequestDto, CreateUpdateApplyFortbDto>
    {
    }
}
