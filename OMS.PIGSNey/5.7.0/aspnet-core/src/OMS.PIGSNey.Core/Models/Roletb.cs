using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.Models
{
   public class Roletb: AuditedAggregateRoot<int>
    {
        public string RName { get; set; }
    }
}
