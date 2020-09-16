using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.Models
{
   public class CommodityDetailstb: AuditedAggregateRoot<int>
    {
        public string CName { get; set; }
        public int CPId { get; set; }
    }
}
