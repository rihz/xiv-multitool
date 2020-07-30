using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks
{
    public class BLULogTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int ContentId { get; set; }

        public virtual Category Category { get; set; }
        public virtual PvEContent Content { get; set; }
    }

    public class BLULogParse
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public string Content { get; set; }
    }
}
