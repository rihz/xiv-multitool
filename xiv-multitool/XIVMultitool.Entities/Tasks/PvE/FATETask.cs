using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks.PvE
{
    public class FATETask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Location { get; set; }
        //public int ZoneId { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        //public int FATETypeId { get; set; }

        public virtual Category Category { get; set; }
        //public virtual Zone Zone { get; set; }
        //public virtual FATEType FATEType { get; set; }
    }

    public class FATEParse
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Level { get; set; }
    }
}
