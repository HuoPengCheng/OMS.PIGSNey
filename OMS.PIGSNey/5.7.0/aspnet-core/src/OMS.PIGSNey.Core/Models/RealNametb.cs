using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.Models
{
   public class RealNametb: AuditedAggregateRoot<int>
    {
        public int UId { get; set; }
        public string Prcture1 { get; set; }
        public string Prcture2 { get; set; }
    }
}
