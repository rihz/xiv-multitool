using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks
{
    public class CollectionTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Method { get; set; }
        public int CollectionTypeId { get; set; }

        public virtual Category Category { get; set; }
        public virtual CollectionType CollectionType { get; set; }
    }

    public class CollectionParse
    {
        public string Name { get; set; }
        public string Method { get; set; }
    }
}
