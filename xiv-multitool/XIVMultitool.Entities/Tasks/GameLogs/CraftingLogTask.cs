using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks
{
    public class CraftingLogTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        //public int DisciplineId { get; set; }
        public int CraftingLogTypeId { get; set; }

        public virtual Category Category { get; set; }
        //public virtual Discipline Discipline { get; set; }
        public virtual CraftingLogType CraftingLogType { get; set; }
    }

    public class CraftingLogParse
    {
        public string Name { get; set; }
        public string Level { get; set; }
    }
}
