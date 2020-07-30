using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;

namespace XIVChecklist.Entities.Tasks
{
    public class BLUSpellTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<BLUSpellLocation> Locations { get; set; }
    }

    public class BLUSpellParse
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Mobs { get; set; }
        public string Location { get; set; }
    }
}
