using Alta.DTOs;
using Alta.Entities.POCOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Profiles
{
    public class HeartbeatInitiateProfile : Profile
    {
        public HeartbeatInitiateProfile()
        {
            CreateMap<HeartbeatInitiate, HeartBeatInitiateDTO>()
               .ReverseMap()
               .ForPath(poco => poco.TRANID, opts => opts.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CTRL_SEG.TRANID))
        }
    }
}
