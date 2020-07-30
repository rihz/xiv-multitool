using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks.Logs
{
    public class GatheringLogTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int GatherTypeId { get; set; }
        public string Level { get; set; }
        public string Name { get; set; }
        //public int ZoneId { get; set; }
        public string Location { get; set; }

        public virtual Category Category { get; set; }
        public virtual GatherType GatherType { get; set; }
        //public virtual Zone Zone { get; set; }
    }

    public class GatheringLogParse
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public string Location { get; set; }
        public string Zone { get; set; }
    }
}
