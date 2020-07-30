using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using XIVChecklist.Entities.Tasks;

namespace XIVChecklist.Entities
{
    public class AppUser : IdentityUser
    {
        public virtual ICollection<UserTask> UserTasks { get; set; }
    }
}
