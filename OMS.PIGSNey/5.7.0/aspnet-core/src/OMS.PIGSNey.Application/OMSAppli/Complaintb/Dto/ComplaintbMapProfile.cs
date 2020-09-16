using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.Complaintb.Dto
{
   public class ComplaintbMapProfile: Profile
    {
        public ComplaintbMapProfile()
        {
            CreateMap<ComplaintbDto, OMS.PIGSNey.Models.Complaintb>();
            CreateMap<CreateUpdateComplaintbDto, OMS.PIGSNey.Models.Complaintb>();
        }
    }
}
