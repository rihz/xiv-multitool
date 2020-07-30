using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks.GameLogs
{
    public class HuntingLogTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int HuntingLogTypeId { get; set; }
        public string Number { get; set; }
        public string Level { get; set; }
        
        public virtual ICollection<HuntingLogMob> Mobs { get; set; }
        public virtual HuntingLogType HuntingLogType { get; set; }
        public virtual Category Category { get; set; }
    }

    public class HuntingLogParse
    {
        public string Record { get; set; }
        public string Level { get; set; }
        public string Mobs { get; set; }
        public string Zone { get; set; }
        public string Location { get; set; }
    }
}
