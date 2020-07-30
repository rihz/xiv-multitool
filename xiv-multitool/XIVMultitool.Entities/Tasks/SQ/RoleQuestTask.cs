using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks.SQ
{
    public class RoleQuestTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int JobRoleId { get; set; }
        public int Level { get; set; }

        public virtual Category Category { get; set; }
        public virtual JobRole JobRole { get; set; }
    }

    public class RoleQuestParse
    {
        public string Role { get; set; }
        public string Level { get; set; }
        public string Name { get; set; }
    }
}
