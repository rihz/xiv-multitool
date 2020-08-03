using System;
using System.Collections.Generic;
using System.Text;

namespace XIVMultitool.Entities.XIVLedger
{
    public class MarketTransaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int SoldFor { get; set; }
        public DateTime DateListed { get; set; }
        public DateTime DateSold { get; set; }
    }
}
