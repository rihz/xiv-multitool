using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;

namespace XIVChecklist.Entities.Tasks
{
    public class BLUCarnivaleTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Stage { get; set; }
        public string StandardMinute { get; set; }
        public string StandardSecond { get; set; }
        public string IdealMinute { get; set; }
        public string IdealSecond { get; set; }

        public virtual Category Category { get; set; }
    }

    public class BLUCarnivaleParse
    {
        public string Name { get; set; }
        public int Stage { get; set; }
        public string Standard { get; set; }
        public string Ideal { get; set; }
    }
}
