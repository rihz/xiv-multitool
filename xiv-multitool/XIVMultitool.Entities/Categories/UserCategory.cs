using System;
using System.Collections.Generic;
using System.Text;

namespace XIVChecklist.Entities.Categories
{
    public class UserCategory
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int CategoryId { get; set; }
        public bool IsTracked { get; set; }

        public virtual AppUser User { get; set; }
        public virtual Category Category { get; set; }
    }
}
