﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVMultitool.Api.Controllers.XIVLedger.Sheets
{
    public interface ISheetService
    {
        IEnumerable<SheetModel> GetSheets(string userId);
        SheetModel AddSheet(SheetModel model);
        MarketTransactionModel AddMarketTransaction(MarketTransactionModel model);
        SheetModel UpdateSheet(SheetModel model);
        void DeleteSheet(int id);
    }

    public class SheetService : ISheetService
    {
        ISheetRepository _repo;

        public SheetService(ISheetRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<SheetModel> GetSheets(string userId)
        {
            return _repo.GetSheets(userId);
        }

        public SheetModel AddSheet(SheetModel model)
        {
            return _repo.AddSheet(model);
        }

        public MarketTransactionModel AddMarketTransaction(MarketTransactionModel model)
        {
            return _repo.AddMarketTransaction(model);
        }

        public SheetModel UpdateSheet(SheetModel model)
        {
            return _repo.UpdateSheet(model);
        }

        public void DeleteSheet(int id)
        {
            _repo.DeleteSheet(id);
        }
    }
}