using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Tasks;
using XIVChecklist.Entities.Tasks.PvE;

namespace XIVChecklist.Entities.Common
{
    public class PvEContent : ICommon
    {
        public int Id { get; set; }
        public int PvEContentTypeId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int iLevel { get; set; }

        public virtual PvEContentType ContentType { get; set; }

        public virtual ICollection<BLULogTask> BLULogTasks { get; set; }
        public virtual ICollection<PvETask> PvETasks { get; set; }
    }
}
