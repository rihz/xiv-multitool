using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Tasks.MSQ;

namespace XIVChecklist.Entities.Common
{
    public class MSQType : ICommon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MSQTask> MSQTasks { get; set; }
    }
}
