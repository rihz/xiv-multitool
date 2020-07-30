using System;
using System.Collections.Generic;
using System.Text;

namespace XIVChecklist.Entities.Tasks
{
    public class BLUSpellTaskLocation
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public int SpellLocationId { get; set; }

        public virtual BLUSpellLocation SpellLocation { get; set; }
        public virtual BLUSpellTask Spell { get; set; }
    }
}
