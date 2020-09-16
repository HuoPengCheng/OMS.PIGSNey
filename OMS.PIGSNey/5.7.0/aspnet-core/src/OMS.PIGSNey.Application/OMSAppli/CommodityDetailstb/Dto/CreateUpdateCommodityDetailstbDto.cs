using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.CommodityDetailstb.Dto
{
     public class CreateUpdateCommodityDetailstbDto : EntityDto<int>
    {
        [Required]
        public string CName { get; set; }
        [Required]
        public int CPId { get; set; }
    }
}
