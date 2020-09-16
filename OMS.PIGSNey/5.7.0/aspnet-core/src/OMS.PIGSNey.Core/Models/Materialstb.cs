using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.Models
{
   public class Materialstb: AuditedAggregateRoot<int>
    {
        public string MaterialName { get; set; }
        public string MSpecification { get; set; }
        public string MCategory { get; set; }
        public int MAmount { get; set; }
        public string MImg { get; set; }
    }
}
