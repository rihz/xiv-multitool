using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using XIVChecklist.Entities.Tasks;
using XIVMultitool.Entities.Account;
using XIVMultitool.Entities.XIVLedger;
using XIVMultitool.Entities.XIVMultitool;

namespace XIVChecklist.Entities
{
    public class AppUser : IdentityUser
    {
        public virtual ICollection<UserTask> UserTasks { get; set; }
        public virtual ICollection<LedgerSheet> LedgerSheets { get; set; }
        public virtual ICollection<Retainer> Retainers { get; set; }
        public virtual ICollection<LodestoneCharacter> LodestoneCharacters { get; set; }
    }
}
