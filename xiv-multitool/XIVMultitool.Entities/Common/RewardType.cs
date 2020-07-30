using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Tasks;

namespace XIVChecklist.Entities.Common
{
    public class RewardType : ICommon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AchievementReward> AchievementRewards { get; set; }
    }

    public class Reward
    {
        public string Name { get; set; }
        public int RewardTypeId { get; set; }
        public string RewardTypeName { get; set; }
    }

    public class AchievementReward
    {
        public int Id { get; set; }
        public int AchievementId { get; set; }
        public string Reward { get; set; }
        public int RewardTypeId { get; set; }

        public virtual AchievementTask Achievement { get; set; }
        public virtual RewardType RewardType { get; set; }
    }
}
