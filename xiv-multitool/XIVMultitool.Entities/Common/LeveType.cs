using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Tasks.PvE;

namespace XIVChecklist.Entities.Common
{
    public class LeveType : ICommon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<LeveTask> LeveTasks { get; set; }
    }
}
