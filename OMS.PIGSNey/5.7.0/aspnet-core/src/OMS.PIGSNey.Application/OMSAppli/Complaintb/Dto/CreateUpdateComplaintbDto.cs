using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.Complaintb.Dto
{
   public class CreateUpdateComplaintbDto:EntityDto<int>
    {
        [Required]
        public string Ordernumber { get; set; }
        [Required]
        public int UId1 { get; set; }
        [Required]
        public int UId2 { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public string Img { get; set; }
        [Required]
        public int State { get; set; }
    }
}
