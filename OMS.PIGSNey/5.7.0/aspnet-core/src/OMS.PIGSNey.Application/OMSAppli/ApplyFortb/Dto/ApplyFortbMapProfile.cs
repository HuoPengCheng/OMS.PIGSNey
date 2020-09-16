using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using OMS.PIGSNey.Models;

namespace OMS.PIGSNey.OMSAppli.ApplyFortb.Dto
{
   public class ApplyFortbMapProfile:Profile
    {
        public ApplyFortbMapProfile()
        {
            CreateMap<ApplyFortbDto, OMS.PIGSNey.Models.ApplyFortb>();
            CreateMap<CreateUpdateApplyFortbDto, OMS.PIGSNey.Models.ApplyFortb>();
        }
    }
}
