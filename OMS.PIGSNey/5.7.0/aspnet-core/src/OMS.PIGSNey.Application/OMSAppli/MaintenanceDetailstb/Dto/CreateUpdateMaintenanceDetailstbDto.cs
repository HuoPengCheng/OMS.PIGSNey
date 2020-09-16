using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.MaintenanceDetailstb.Dto
{
   public class CreateUpdateMaintenanceDetailstbDto:EntityDto<int>
    {
        public int URDId { get; set; }
        public int UId { get; set; }
    }
}
