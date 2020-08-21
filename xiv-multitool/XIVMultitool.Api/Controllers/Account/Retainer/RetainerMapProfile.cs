using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVMultitool.Api.Controllers.Account.Retainer
{
    public class RetainerMapProfile : Profile
    {
        public RetainerMapProfile()
        {
            CreateMap<Entities.XIVMultitool.Retainer, RetainerModel>()
                .ReverseMap();

            CreateMap<Entities.XIVMultitool.RetainerLabel, RetainerLabelModel>()
                .ReverseMap();
        }
    }
}
