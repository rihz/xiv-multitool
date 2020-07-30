using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;

namespace XIVChecklist.Entities.Tasks
{
    public class UserTask
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int CategoryId { get; set; }
        public int TaskId { get; set; }
        public bool IsTracked { get; set; }
        public bool IsComplete { get; set; }

        public virtual AppUser User { get; set; }
        public virtual Category Category { get; set; }
    }
}
