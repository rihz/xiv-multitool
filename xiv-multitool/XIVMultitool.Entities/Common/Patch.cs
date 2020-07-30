using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Tasks.GameLogs;

namespace XIVChecklist.Entities.Common
{
    public class Patch : ICommon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }

        public ICollection<SightseeingLogTask> SightseeingTasks { get; set; }
    }
}
