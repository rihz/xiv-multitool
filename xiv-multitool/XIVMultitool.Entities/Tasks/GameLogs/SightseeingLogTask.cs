using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks.GameLogs
{
    public class SightseeingLogTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int PatchId { get; set; }
        public string Number { get; set; }
        //public int LocationId { get; set; }
        public string Weather { get; set; }
        public string Time { get; set; }
        public string Emote { get; set; }

        public virtual Category Category { get; set; }
        public virtual Patch Patch { get; set; }
        //public virtual Location Location { get; set; }
    }

    public class SightseeingLogParse
    {
        public string Set { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Zone { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public string Time { get; set; }
        public string Emote { get; set; }
    }
}
