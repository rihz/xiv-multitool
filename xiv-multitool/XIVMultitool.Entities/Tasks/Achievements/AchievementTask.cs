using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks
{
    public class AchievementTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public string Description { get; set; }
        public int AchievementTypeId { get; set; }
        [NotMapped]
        public string Reward { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<AchievementReward> Rewards { get; set; }
        public virtual AchievementType AchievementType { get; set; }
    }
}
