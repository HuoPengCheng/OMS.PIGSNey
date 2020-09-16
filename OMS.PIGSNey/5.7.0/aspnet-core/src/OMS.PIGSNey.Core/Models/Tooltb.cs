﻿using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.Models
{
   public class Tooltb: AuditedAggregateRoot<int>
    {
        public string ToolName { get; set; }
        public string TSpecification { get; set; }
        public string TCategory { get; set; }
        public string Img { get; set; }
    }
}
