using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Tasks.Logs;

namespace XIVChecklist.Entities.Common
{
    public class GatherType : ICommon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GatheringLogTask> GatheringLogTasks { get; set; }
    }
}
