using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks.SQ
{
    public class SQTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int SQTypeId { get; set; }

        public virtual Category Category { get; set; }
        public virtual SQType SQType { get; set; }
    }

    public class SQTaskParse
    {
        public string Level { get; set; }
        public string Name { get; set; }
    }
}
