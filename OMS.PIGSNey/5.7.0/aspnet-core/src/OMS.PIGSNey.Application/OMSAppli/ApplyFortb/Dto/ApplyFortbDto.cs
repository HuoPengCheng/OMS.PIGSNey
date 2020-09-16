using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace OMS.PIGSNey.OMSAppli.ApplyFortb.Dto
{
   public class ApplyFortbDto: EntityDto<int>
    {
        public string MaterialName { get; set; }
        public int UId { get; set; }
        public int MaterialAmount { get; set; }
    }
}
