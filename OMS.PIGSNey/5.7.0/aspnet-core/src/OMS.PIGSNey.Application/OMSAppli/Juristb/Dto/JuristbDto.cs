using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.Juristb.Dto
{
    public class JuristbDto: EntityDto<int>
    {
        public int RId { get; set; }
        public int JAdd { get; set; }
        public int JDel { get; set; }
        public int JShow { get; set; }
        public int JUpt { get; set; }
    }
}
