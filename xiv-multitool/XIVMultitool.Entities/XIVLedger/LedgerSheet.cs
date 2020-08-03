using System;
using System.Collections.Generic;
using System.Text;

namespace XIVMultitool.Entities.XIVLedger
{
    public class LedgerSheet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public int StartingFunds { get; set; }
    }
}
