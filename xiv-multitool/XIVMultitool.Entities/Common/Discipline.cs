using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Tasks.Collections;
using XIVChecklist.Entities.Tasks.SQ;

namespace XIVChecklist.Entities.Common
{
    public class Discipline : ICommon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public virtual ICollection<ClassQuestTask> ClassQuestTasks { get; set; }
        public virtual ICollection<RelicWeaponTask> RelicWeaponTasks { get; set; }
    }
}
