using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Tasks.Logs;

namespace XIVChecklist.Entities.Common
{
    public class Zone : ICommon
    {
        public int Id { get; set; }

        public int RegionId { get; set; }

        public string Name { get; set; }

        public virtual Region Region { get; set; }

        public virtual ICollection<FishGuideTask> FishGuideTasks { get; set; }
        public virtual ICollection<GatheringLogTask> GatheringLogTasks { get; set; }
    }
}
