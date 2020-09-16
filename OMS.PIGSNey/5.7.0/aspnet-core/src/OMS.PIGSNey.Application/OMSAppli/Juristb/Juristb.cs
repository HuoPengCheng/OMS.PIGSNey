using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using OMS.PIGSNey.OMSAppli.Juristb.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.Juristb
{
    public class Juristb: CrudAppService<Models.Juristb,JuristbDto,int, PagedAndSortedResultRequestDto, CreateUpdateJuristbDto>,IJuristb
    {
        public Juristb(IRepository<Models.Juristb, int> repository)
            : base(repository)
        {

        }

        public override JuristbDto Create(CreateUpdateJuristbDto input)
        {
            return base.Create(input);
        }

        public override JuristbDto Get(EntityDto<int> input)
        {
            return base.Get(input);
        }

        public override void Delete(EntityDto<int> input)
        {
            base.Delete(input);
        }

        public override PagedResultDto<JuristbDto> GetAll(PagedAndSortedResultRequestDto input)
        {
            return base.GetAll(input);
        }

        public override JuristbDto Update(CreateUpdateJuristbDto input)
        {
            return base.Update(input);
        }
    }
}
