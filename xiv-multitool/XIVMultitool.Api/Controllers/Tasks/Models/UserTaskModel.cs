using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XIVChecklist.Entities;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Tasks;

namespace XIVChecklist.Api.Controllers.Tasks.Models
{
    public class UserTaskModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int CategoryId { get; set; }
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public bool IsTracked { get; set; }
        public bool IsComplete { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual Category Category { get; set; }
        public virtual ITask Task { get; set; }
    } 
}
