using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XIVMultitool.Entities.XIVLedger;

namespace XIVMultitool.Api.Controllers.XIVLedger.Sheets
{
    public class SheetMapProfile : Profile
    {
        public SheetMapProfile()
        {
            CreateMap<LedgerSheet, SheetModel>()
                .ReverseMap();
        }
    }
}
