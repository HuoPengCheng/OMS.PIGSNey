using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using OMS.PIGSNey.OMSAppli.Complaintb.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.Complaintb
{
   public class Complaintb: CrudAppService<Models.Complaintb,ComplaintbDto,int, PagedAndSortedResultRequestDto, CreateUpdateComplaintbDto>,IComplaintb
    {
        public Complaintb(IRepository<Models.Complaintb, int> repository)
            : base(repository)
        {

        }
        public override ComplaintbDto Get(EntityDto<int> input)
        {
            return base.Get(input);
        }
        public override PagedResultDto<ComplaintbDto> GetAll(PagedAndSortedResultRequestDto input)
        {
            return base.GetAll(input);
        }
        public override ComplaintbDto Create(CreateUpdateComplaintbDto input)
        {
            return base.Create(input);
        }
        public override ComplaintbDto Update(CreateUpdateComplaintbDto input)
        {
            return base.Update(input);
        }
        public override void Delete(EntityDto<int> input)
        {
            base.Delete(input);
        }
    }
}
