using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace OMS.PIGSNey.Models
{
   public class UserInfotb:AuditedAggregateRoot<int>
    {
        public string UName { get; set; }
        public string UAccount { get; set; }
        public string UPwd { get; set; }
        public string UPhone { get; set; }
        public int RId { get; set; }
        public int UState { get; set; }

    }
}
