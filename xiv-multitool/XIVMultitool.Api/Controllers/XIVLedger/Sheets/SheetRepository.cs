using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XIVChecklist.Api.Extensions;
using XIVChecklist.Data.Context;
using XIVMultitool.Entities.XIVLedger;
using LodestoneParser;

namespace XIVMultitool.Api.Controllers.XIVLedger.Sheets
{
    public interface ISheetRepository
    {
        IEnumerable<SheetModel> GetSheets(string userId);
        SheetModel AddSheet(SheetModel model);
        MarketTransactionModel AddMarketTransaction(MarketTransactionModel model);
        SheetModel UpdateSheet(SheetModel model);
        void DeleteSheet(int id);
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
            var sheets = _context.LedgerSheet.Where(x => x.UserId == userId)
                .Include(x => x.MarketTransactions);

            return _mapper.MapEnumerable<LedgerSheet, SheetModel>(sheets);
        }

        public SheetModel AddSheet(SheetModel model)
        {
            var entity = _mapper.Map<LedgerSheet>(model);

            _context.LedgerSheet.Add(entity);

            _context.SaveChanges();

            return _mapper.Map<SheetModel>(entity);
        }

        public MarketTransactionModel AddMarketTransaction(MarketTransactionModel model)
        {
            var entity = _mapper.Map<MarketTransaction>(model);

            _context.MarketTransaction.Add(entity);

            _context.SaveChanges();

            return _mapper.Map<MarketTransactionModel>(entity);
        }

        public SheetModel UpdateSheet(SheetModel model)
        {
            var entity = _mapper.Map<LedgerSheet>(model);

            _context.LedgerSheet.Update(entity);

            _context.SaveChanges();

            return _mapper.Map<SheetModel>(entity);
        }

        public void DeleteSheet(int id)
        {
            var entity = _context.LedgerSheet.FirstOrDefault(x => x.Id == id);

            if(entity != default(LedgerSheet))
            {
                _context.LedgerSheet.Remove(entity);

                _context.SaveChanges();
            }
        }
    }
}
