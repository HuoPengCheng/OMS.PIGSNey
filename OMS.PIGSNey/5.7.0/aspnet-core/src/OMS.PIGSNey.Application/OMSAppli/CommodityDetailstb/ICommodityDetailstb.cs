using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OMS.PIGSNey.OMSAppli.CommodityDetailstb.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.CommodityDetailstb
{
   public interface ICommodityDetailstb: ICrudAppService<CommodityDetailstbDto, int, PagedAndSortedResultRequestDto, CreateUpdateCommodityDetailstbDto>
    {
    }
}
