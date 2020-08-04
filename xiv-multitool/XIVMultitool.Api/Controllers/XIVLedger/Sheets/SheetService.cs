using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVMultitool.Api.Controllers.XIVLedger.Sheets
{
    public interface ISheetService
    {
        IEnumerable<SheetModel> GetSheets(string userId);
        SheetModel AddSheet(SheetModel model);
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
    }
}
