using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using imenik.Controllers.Resources;
using imenik_app.Models;

namespace imenik_app.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Imenik, ImenikResources>();

            CreateMap<ImenikResources, Imenik>()
                .ForMember(v => v.Id, opt => opt.Ignore());
        }

    }
}
