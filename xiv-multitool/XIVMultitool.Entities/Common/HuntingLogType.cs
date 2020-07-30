using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Tasks.GameLogs;

namespace XIVChecklist.Entities.Common
{
    public class HuntingLogType : ICommon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<HuntingLogTask> HuntingLogTasks { get; set; }
    }
}
