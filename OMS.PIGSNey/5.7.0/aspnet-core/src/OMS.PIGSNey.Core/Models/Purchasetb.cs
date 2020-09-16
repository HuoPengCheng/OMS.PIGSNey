using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.Models
{
   public class Purchasetb: AuditedAggregateRoot<int>
    {
        public string MAterialName { get; set; }
        public string Category { get; set; }
        public int PAmount { get; set; }
    }
}
