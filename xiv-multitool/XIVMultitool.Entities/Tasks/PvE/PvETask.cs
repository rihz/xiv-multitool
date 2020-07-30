using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks.PvE
{
    public class PvETask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int ContentId { get; set; }

        public virtual Category Category { get; set; }
        public virtual PvEContent Content { get; set; }
    }

    public class PvEParse
    {
        public int Level { get; set; }
        public string Name { get; set; }
    }
}
