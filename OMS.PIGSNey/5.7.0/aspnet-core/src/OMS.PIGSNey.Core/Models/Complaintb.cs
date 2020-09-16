using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.Models
{
   public class Complaintb: AuditedAggregateRoot<int>
    {
        public string Ordernumber { get; set; }
        public int UId1 { get; set; }
        public int UId2 { get; set; }
        public string Comment { get; set; }
        public string Img { get; set; }
        public int State { get; set; }
    }
}
