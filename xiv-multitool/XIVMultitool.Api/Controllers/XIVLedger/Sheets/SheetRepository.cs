using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XIVChecklist.Api.Extensions;
using XIVChecklist.Data.Context;
using XIVMultitool.Entities.XIVLedger;

namespace XIVMultitool.Api.Controllers.XIVLedger.Sheets
{
    public interface ISheetRepository
    {
        IEnumerable<SheetModel> GetSheets(string userId);
        SheetModel AddSheet(SheetModel model);
    }

    public class SheetRepository : ISheetRepository
    {
        XIVContext _context;
        IMapper _mapper;

        public SheetRepository(XIVContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<SheetModel> GetSheets(string userId)
        {
            var sheets = _context.LedgerSheet.Where(x => x.UserId == userId);

            return _mapper.MapEnumerable<LedgerSheet, SheetModel>(sheets);
        }

        public SheetModel AddSheet(SheetModel model)
        {
            var entity = _mapper.Map<LedgerSheet>(model);

            _context.LedgerSheet.Add(entity);

            _context.SaveChanges();

            return _mapper.Map<SheetModel>(entity);
        }
    }
}
