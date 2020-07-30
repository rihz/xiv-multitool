using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Tasks.SQ;

namespace XIVChecklist.Entities.Common
{
    public class SQType : ICommon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SQTask> SidequestTasks { get; set; }
    }
}
