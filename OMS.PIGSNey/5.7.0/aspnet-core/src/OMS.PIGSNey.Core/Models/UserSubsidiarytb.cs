using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.Models
{
   public class UserSubsidiarytb: AuditedAggregateRoot<int>
    {
        public int UId { get; set; }
        public int TId { get; set; }
        public DateTime DrawTime { get; set; }
    }
}
