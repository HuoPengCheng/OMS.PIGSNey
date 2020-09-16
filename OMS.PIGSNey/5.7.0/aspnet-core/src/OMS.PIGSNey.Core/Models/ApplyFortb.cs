using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.Models
{
   public class ApplyFortb: AuditedAggregateRoot<int>
    {
        public string MaterialName { get; set; }
        public int UId { get; set; }
        public int MaterialAmount { get; set; }
    }
}
