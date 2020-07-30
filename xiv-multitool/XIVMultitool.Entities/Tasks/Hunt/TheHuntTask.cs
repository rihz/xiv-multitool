using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks
{
    public class TheHuntTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Location { get; set; }
        //public int ZoneId { get; set; }

        public virtual Category Category { get; set; }
        //public virtual Zone Zone { get; set; }
    }

    public class TheHuntParse
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Location { get; set; }
    }
}
