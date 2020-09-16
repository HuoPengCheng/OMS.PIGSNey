using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.PIGSNey.OMSAppli.Juristb.Dto
{
    class JuristbMapProfile:Profile
    {
        public JuristbMapProfile()
        {
            CreateMap<JuristbDto, OMS.PIGSNey.Models.Juristb>();
            CreateMap<CreateUpdateJuristbDto, OMS.PIGSNey.Models.Juristb>();
        }
    }
}
