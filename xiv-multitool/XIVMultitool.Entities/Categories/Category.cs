using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Tasks;
using XIVChecklist.Entities.Tasks.Collections;
using XIVChecklist.Entities.Tasks.GameLogs;
using XIVChecklist.Entities.Tasks.Logs;
using XIVChecklist.Entities.Tasks.MSQ;
using XIVChecklist.Entities.Tasks.PvE;
using XIVChecklist.Entities.Tasks.SQ;
using XIVChecklist.Entities.Tasks.Triple_Triad;

namespace XIVChecklist.Entities.Categories
{
    public class Category
    {
        public Category() { }
        public Category(int id, string name, int position, int? parentCategoryId = null)
        {
            Id = id;
            Name = name;
            ParentCategoryId = parentCategoryId;
            Position = position;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
        public int Position { get; set; }

        public virtual Category ParentCategory { get; set; }

        public virtual ICollection<AchievementTask> AchievementTasks { get; set; }
        public virtual ICollection<BLUCarnivaleTask> BLUCarnivaleTasks { get; set; }
        public virtual ICollection<BLULogTask> BLULogTasks { get; set; }
        public virtual ICollection<BLUSpellTask> BLUSpellTasks { get; set; }
        public virtual ICollection<Category> ChildCategories { get; set; }
        public virtual ICollection<CollectionTask> CollectionTasks { get; set; }
        public virtual ICollection<CraftingLogTask> CraftingLogTasks { get; set; }
        public virtual ICollection<FATETask> FATETasks { get; set; }
        public virtual ICollection<FishGuideTask> FishGuideTasks { get; set; }
        public virtual ICollection<GatheringLogTask> GatheringLogTasks { get; set; }
        public virtual ICollection<TheHuntTask> TheHuntTasks { get; set; }
        public virtual ICollection<LeveTask> LeveTasks { get; set; }
        public virtual ICollection<HuntingLogTask> HuntingLogTasks { get; set; }
        public virtual ICollection<MSQTask> MSQTasks { get; set; }
        public virtual ICollection<OrchestrionTask> OrchestrionTasks { get; set; }
        public virtual ICollection<PvETask> PvETasks { get; set; }
        public virtual ICollection<SightseeingLogTask> SightseeingTasks { get; set; }
        public virtual ICollection<CardTask> CardTasks { get; set; }
        public virtual ICollection<OpponentTask> OpponentTasks { get; set; }
        public virtual ICollection<BeastQuestTask> BeastQuestTasks { get; set; }
        public virtual ICollection<ClassQuestTask> ClassQuestTasks { get; set; }
        public virtual ICollection<SQTask> SidequestTasks { get; set; }
        public virtual ICollection<RoleQuestTask> RoleQuestTasks { get; set; }
        public virtual ICollection<RelicWeaponTask> RelicWeaponTasks { get; set; }
        public virtual ICollection<UserTask> UserTasks { get; set; }

        public Category ResetParentCategory()
        {
            ParentCategoryId = 0;

            return this;
        }
    }
}
