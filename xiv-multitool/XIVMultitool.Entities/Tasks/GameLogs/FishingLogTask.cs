using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks.Logs
{
    public class FishingLogTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int iLevel { get; set; }
        public int ZoneId { get; set; }
        public Coordinate Coordinate { get; set; }

        public virtual Category Category { get; set; }
        public virtual Zone Zone { get; set; }
    }
}
