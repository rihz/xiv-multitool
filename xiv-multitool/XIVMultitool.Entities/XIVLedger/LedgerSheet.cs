using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities;

namespace XIVMultitool.Entities.XIVLedger
{
    public class LedgerSheet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public int StartingFunds { get; set; }

        public virtual AppUser User { get; set; }
        public virtual ICollection<MarketTransaction> MarketTransactions { get; set; }
    }
}
