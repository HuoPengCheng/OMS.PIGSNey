using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OMS.PIGSNey.OMSAppli.ApplyFortb.Dto;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using OMS.PIGSNey.Models;

namespace OMS.PIGSNey.OMSAppli.ApplyFortb
{
   public class ApplyFortbAppService:
        CrudAppService<
            Models.ApplyFortb,
            ApplyFortbDto,
            int, 
            PagedAndSortedResultRequestDto,
            CreateUpdateApplyFortbDto>,
        IApplicationService
    {
        public ApplyFortbAppService(IRepository<Models.ApplyFortb, int> repository)
            : base(repository)
        {

        }

        public override ApplyFortbDto Create(CreateUpdateApplyFortbDto input)
        {
            return base.Create(input);
        }
        public override ApplyFortbDto Get(EntityDto<int> input)
        {
            return base.Get(input);
        }
        public override PagedResultDto<ApplyFortbDto> GetAll(PagedAndSortedResultRequestDto input)
        {
            return base.GetAll(input);
        }
        public override ApplyFortbDto Update(CreateUpdateApplyFortbDto input)
        {
            return base.Update(input);
        }
        public override void Delete(EntityDto<int> input)
        {
            base.Delete(input);
        }
    }
}
