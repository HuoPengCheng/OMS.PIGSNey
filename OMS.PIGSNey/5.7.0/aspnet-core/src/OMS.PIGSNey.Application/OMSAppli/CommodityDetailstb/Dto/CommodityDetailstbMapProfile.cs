using AutoMapper;
using OMS.PIGSNey.OMSAppli.ApplyFortb.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.CommodityDetailstb.Dto
{
   public class CommodityDetailstbMapProfile: Profile
    {

        public CommodityDetailstbMapProfile()
        {
            CreateMap<CommodityDetailstbDto, OMS.PIGSNey.Models.CommodityDetailstb>();
            CreateMap<CreateUpdateCommodityDetailstbDto, OMS.PIGSNey.Models.CommodityDetailstb>();
        }
    }
}
