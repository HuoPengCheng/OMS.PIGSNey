using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using OMS.PIGSNey.OMSAppli.MaintenanceDetailstb.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.MaintenanceDetailstb
{
    public class MaintenanceDetailstb : CrudAppService<Models.MaintenanceDetailstb, MaintenanceDetailstbDto, int, PagedAndSortedResultRequestDto, CreateUpdateMaintenanceDetailstbDto>, IMaintenanceDetailstb
    {
        public MaintenanceDetailstb(IRepository<Models.MaintenanceDetailstb, int> repository)
        : base(repository)
        {

        }
        public override MaintenanceDetailstbDto Create(CreateUpdateMaintenanceDetailstbDto input)
        {
            return base.Create(input);
        }
        public override MaintenanceDetailstbDto Get(EntityDto<int> input)
        {
            return base.Get(input);
        }
        public override void Delete(EntityDto<int> input)
        {
            base.Delete(input);
        }
        public override PagedResultDto<MaintenanceDetailstbDto> GetAll(PagedAndSortedResultRequestDto input)
        {
            return base.GetAll(input);
        }
        public override MaintenanceDetailstbDto Update(CreateUpdateMaintenanceDetailstbDto input)
        {
            return base.Update(input);
        }
        
    }
}
