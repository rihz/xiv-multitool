using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Tasks;

namespace XIVChecklist.Entities.Common
{
    public class AchievementType : ICommon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AchievementTask> AchievementTasks { get; set; }
    }

    public enum AchievementTypeEnum
    {
        Battle = 1,
        Character,
        Crafting,
        Exploration,
        Gathering,
        Grand_Company,
        Item,
        PvP,
        Quest
    }
}
