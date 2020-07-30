using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Tasks;

namespace XIVChecklist.Entities.Common
{
    public class OrchestrionType : ICommon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OrchestrionTask> OrchestrionTasks { get; set; }
    }
}
