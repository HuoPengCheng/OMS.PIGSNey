using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.ApplyFortb.Dto
{
    public class CreateUpdateApplyFortbDto:EntityDto<int>
    {
        public int AId { get; set; }
        [Required]
        public string MaterialName { get; set; }
        [Required]
        public int UId { get; set; }
        [Required]
        public int MaterialAmount { get; set; }

    }
}
