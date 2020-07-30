using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Tasks.GameLogs;

namespace XIVChecklist.Entities.Common
{
    public class HuntingLogMob : ICommon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public int LocationId { get; set; }
        public string Zone { get; set; }
        public string Location { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public int HuntingLogId { get; set; }

        public virtual HuntingLogTask HuntingLogTask { get; set; }
    }
}
