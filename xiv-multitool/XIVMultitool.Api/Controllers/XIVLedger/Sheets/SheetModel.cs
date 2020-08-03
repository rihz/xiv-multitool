using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVMultitool.Api.Controllers.XIVLedger.Sheets
{
    public class SheetModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public int StartingFunds { get; set; }
    }

    public class MarketTransactionModel
    {
        public int Id { get; set; }
        public int SheetId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int SoldFor { get; set; }
        public DateTime? DateListed { get; set; }
        public DateTime? DateSold { get; set; }
    }
}
