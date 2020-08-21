using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XIVMultitool.Entities.Account;

namespace XIVMultitool.Api.Controllers.Account
{
    public class LodestoneCharacterMapProfile : Profile
    {
        public LodestoneCharacterMapProfile()
        {
            CreateMap<LodestoneCharacterModel, LodestoneCharacter>()
                .ReverseMap();
        }
    }
}
