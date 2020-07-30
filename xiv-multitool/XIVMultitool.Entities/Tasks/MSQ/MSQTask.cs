using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks.MSQ
{
    public class MSQTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public int MSQTypeId { get; set; }

        public virtual Category Category { get; set; }
        public virtual MSQType MSQType { get; set; }
    }

    public class MSQTaskParse
    {
        public string Level { get; set; }
        public string Name { get; set; }
    }
}
