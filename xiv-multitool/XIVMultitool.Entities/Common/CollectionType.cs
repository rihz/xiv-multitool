using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Tasks;

namespace XIVChecklist.Entities.Common
{
    public class CollectionType : ICommon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CollectionTask> CollectionTasks { get; set; }
    }
}
