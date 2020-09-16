using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.Complaintb.Dto
{
   public class ComplaintbLookupDto:EntityDto<int>
    {
        public string Ordernumber { get; set; }
        public int UId1 { get; set; }
        public int UId2 { get; set; }
        public string Comment { get; set; }
        public string Img { get; set; }
        public int State { get; set; }
    }
}
