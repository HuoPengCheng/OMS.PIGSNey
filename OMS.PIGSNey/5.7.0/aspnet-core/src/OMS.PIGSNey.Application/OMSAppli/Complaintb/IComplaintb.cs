using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OMS.PIGSNey.OMSAppli.Complaintb.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.Complaintb
{
   public interface IComplaintb: ICrudAppService<ComplaintbDto,int, PagedAndSortedResultRequestDto, CreateUpdateComplaintbDto>
    {
    }
}
