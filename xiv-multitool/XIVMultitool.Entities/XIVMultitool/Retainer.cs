using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities;

namespace XIVMultitool.Entities.XIVMultitool
{
    public class Retainer
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }

        public virtual AppUser User { get; set; }

        public ICollection<RetainerLabel> Labels { get; set; }
    }
}
