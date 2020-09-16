using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.CommodityDetailstb.Dto
{
   public class CommodityDetailstbLookupDto: EntityDto<int>
    {
        public string CName { get; set; }
        public int CPId { get; set; }
    }
}
