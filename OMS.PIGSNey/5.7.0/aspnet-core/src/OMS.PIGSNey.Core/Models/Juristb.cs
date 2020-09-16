﻿using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.Models
{
   public class Juristb: AuditedAggregateRoot<int>
    {
        public int RId { get; set; }
        public int JAdd { get; set; }
        public int JDel { get; set; }
        public int JShow { get; set; }
        public int JUpt { get; set; }
    }
}
