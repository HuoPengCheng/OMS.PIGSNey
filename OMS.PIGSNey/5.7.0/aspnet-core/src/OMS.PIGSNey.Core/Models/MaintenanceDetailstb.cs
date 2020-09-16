﻿using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.Models
{
   public class MaintenanceDetailstb: AuditedAggregateRoot<int>
    {
        public int URDId { get; set; }
        public int UId { get; set; }
    }
}
