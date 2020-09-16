using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using OMS.PIGSNey.OMSAppli.CommodityDetailstb.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.CommodityDetailstb
{
   public class CommodityDetailstb:CrudAppService<Models.CommodityDetailstb,CommodityDetailstbDto,int, PagedAndSortedResultRequestDto, CreateUpdateCommodityDetailstbDto>,ICommodityDetailstb
    {
        public CommodityDetailstb(IRepository<Models.CommodityDetailstb, int> repository)
            : base(repository)
        {

        }
        public override CommodityDetailstbDto Create(CreateUpdateCommodityDetailstbDto input)
        {
            return base.Create(input);
        }
        public override CommodityDetailstbDto Get(EntityDto<int> input)
        {
            return base.Get(input);
        }
        public override PagedResultDto<CommodityDetailstbDto> GetAll(PagedAndSortedResultRequestDto input)
        {
            return base.GetAll(input);
        }
        public override void Delete(EntityDto<int> input)
        {
            base.Delete(input);
        }
        public override CommodityDetailstbDto Update(CreateUpdateCommodityDetailstbDto input)
        {
            return base.Update(input);
        }
    }
}
