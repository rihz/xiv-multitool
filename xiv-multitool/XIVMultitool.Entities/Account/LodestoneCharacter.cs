using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities;

namespace XIVMultitool.Entities.Account
{
    public class LodestoneCharacter
    {
        public int Id { get; set; }
        public string CharacterId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Server { get; set; }

        public virtual AppUser User { get; set; }
    }
}
