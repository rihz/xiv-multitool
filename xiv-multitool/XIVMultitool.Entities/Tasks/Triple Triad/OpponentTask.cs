using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks
{
    public class OpponentTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Zone { get; set; }
        public string Location { get; set; }
        //public int ZoneId { get; set; }
        //public Coordinate Coordinate { get; set; }

        public virtual Category Category { get; set; }
        //public virtual Zone Zone { get; set; }
    }

    public class OpponentParse
    {
        public string Name { get; set; }
        public string Zone { get; set; }
        public string Location { get; set; }
    }
}
