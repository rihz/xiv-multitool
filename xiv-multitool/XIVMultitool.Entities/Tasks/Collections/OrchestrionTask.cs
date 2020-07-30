using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks
{
    public class OrchestrionTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Method { get; set; }
        public int OrchestrionTypeId { get; set; }

        public virtual Category Category { get; set; }
        public virtual OrchestrionType OrchestrionType { get; set; }
    }

    public class OrchestrionParse
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Method { get; set; }
    }
}
