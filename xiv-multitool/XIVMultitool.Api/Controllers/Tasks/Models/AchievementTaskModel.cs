using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XIVChecklist.Api.Controllers.Tasks.Models;
using XIVChecklist.Entities.Common;
using XIVChecklist.Entities.Tasks;

namespace XIVChecklist.Api.Controllers.Tasks
{
    ///<see cref="AchievementTask"/>
    public class AchievementTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int Points { get; set; }
        public IEnumerable<AchievementRewardModel> Rewards { get; set; }
        public int AchievementTypeId { get; set; }
        public string AchievementTypeName { get; set; }
    }

    public class AchievementRewardModel
    {
        public int Id { get; set; }
        public int AchievementId { get; set; }
        public int RewardTypeId { get; set; }
        public string RewardName { get; set; }        
    }
}
