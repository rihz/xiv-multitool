using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks.PvE
{
    public class LeveTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        //public int ZoneId { get; set; }
        public int LeveTypeId { get; set; }
        public string NPCName { get; set; }

        public virtual Category Category { get; set; }
        //public virtual Zone Zone { get; set; }
        public virtual LeveType LeveType { get; set; }
    }

    public class LeveParse
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public string Zone { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string NPC { get; set; }
    }
}
