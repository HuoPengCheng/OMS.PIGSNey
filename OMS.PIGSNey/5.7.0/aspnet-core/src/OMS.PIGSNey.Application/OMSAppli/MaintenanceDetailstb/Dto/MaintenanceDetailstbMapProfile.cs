using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.MaintenanceDetailstb.Dto
{
   public  class MaintenanceDetailstbMapProfile:Profile
    {
        public MaintenanceDetailstbMapProfile()
        {
            CreateMap<MaintenanceDetailstbDto, Models.MaintenanceDetailstb>();
            CreateMap<CreateUpdateMaintenanceDetailstbDto, Models.MaintenanceDetailstb>();

        }
    }
}
