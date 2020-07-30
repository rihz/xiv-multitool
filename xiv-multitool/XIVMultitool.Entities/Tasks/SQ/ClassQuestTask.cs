using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks.SQ
{
    public class ClassQuestTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int DisciplineId { get; set; }
        public int Level { get; set; }

        public virtual Category Category { get; set; }
        public virtual Discipline Discipline { get; set; }
    }

    public class ClassQuestParse
    {
        public string Discipline { get; set; }
        public string Level { get; set; }
        public string Name { get; set; }
    }
}
