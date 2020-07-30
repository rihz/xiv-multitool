using System;
using System.Collections.Generic;
using System.Text;

namespace XIVChecklist.Entities.Tasks
{
    public class BLUSpellLocation
    {
        public int Id { get; set; }
        public int BLUSpellTaskId { get; set; }
        public string MobName { get; set; }
        public string LocationName { get; set; }

        public virtual BLUSpellTask Task { get; set; }
    }
}
