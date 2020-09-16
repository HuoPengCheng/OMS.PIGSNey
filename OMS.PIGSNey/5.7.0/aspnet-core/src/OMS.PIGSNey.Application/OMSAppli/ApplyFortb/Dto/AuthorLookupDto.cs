using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.ApplyFortb.Dto
{
    class AuthorLookupDto: EntityDto<int>
    {
        public string MaterialName { get; set; }
        public int UId { get; set; }
        public int MaterialAmount { get; set; }
    }
}
