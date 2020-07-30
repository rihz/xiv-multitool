using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed;
using XIVChecklist.Entities;
using XIVChecklist.Entities.Common;
using XIVChecklist.Entities.Tasks;
using XIVChecklist.Entities.Tasks.Collections;
using XIVChecklist.Entities.Tasks.GameLogs;
using XIVChecklist.Entities.Tasks.Logs;
using XIVChecklist.Entities.Tasks.MSQ;
using XIVChecklist.Entities.Tasks.PvE;
using XIVChecklist.Entities.Tasks.SQ;
using XIVChecklist.Entities.Tasks.Triple_Triad;

namespace XIVChecklist.Data.Context
{
    public partial class XIVContext
    {
        public virtual DbSet<AchievementTask> AchievementTask { get; set; }
        public virtual DbSet<AchievementReward> AchievementReward { get; set; }
        public virtual DbSet<BLUCarnivaleTask> BLUCarnivaleTask { get; set; }
        public virtual DbSet<BLULogTask> BLULogTask { get; set; }
        public virtual DbSet<BLUSpellTask> BLUSpellTask { get; set; }
        public virtual DbSet<BLUSpellLocation> BLUSpellLocation { get; set; }
        public virtual DbSet<CollectionTask> CollectionTask { get; set; }
        public virtual DbSet<OrchestrionTask> OrchestrionTask { get; set; }
        public virtual DbSet<CraftingLogTask> CraftingLogTask { get; set; }
        public virtual DbSet<FATETask> FATETask { get; set; }
        public virtual DbSet<FishGuideTask> FishGuideTasks { get; set; }
        public virtual DbSet<GatheringLogTask> GatheringLogTasks { get; set; }
        public virtual DbSet<MSQTask> MSQTasks { get; set; }
        public virtual DbSet<TheHuntTask> TheHuntTasks { get; set; }
        public virtual DbSet<LeveTask> LeveTasks { get; set; }
        public virtual DbSet<HuntingLogTask> HuntingLogTasks { get; set; }
        public virtual DbSet<PvETask> PvETasks { get; set; }
        public virtual DbSet<SightseeingLogTask> SightseeingLogTasks { get; set; }
        public virtual DbSet<CardTask> CardTasks { get; set; }
        public virtual DbSet<OpponentTask> OpponentTasks { get; set; }
        public virtual DbSet<BeastQuestTask> BeastQuestTasks { get; set; }
        public virtual DbSet<ClassQuestTask> ClassQuestTasks { get; set; }
        public virtual DbSet<SQTask> SidequestTasks { get; set; }
        public virtual DbSet<RoleQuestTask> RoleQuestTasks { get; set; }
        public virtual DbSet<RelicWeaponTask> RelicWeaponTasks { get; set; }
        public virtual DbSet<UserTask> UserTasks { get; set; }

        public void OnModelCreating_Tasks(ModelBuilder builder)
        {
            var achievementTasks = SeedTasks.SeedAchievementTasks();
            var bluSpellTasks = SeedTasks.SeedBLUSpellTasks();
            var bluSpellLocations = new List<BLUSpellLocation>();
            var locationId = 0;
            var huntingSeed = new HuntingLogSeed();

            //Debugger.Launch();

            var huntingResults = huntingSeed.Seed();

            foreach (var task in bluSpellTasks)
            {
                bluSpellLocations.AddRange(task.Locations.Select(x => new BLUSpellLocation
                {
                    Id = ++locationId,
                    BLUSpellTaskId = x.BLUSpellTaskId,
                    LocationName = x.LocationName,
                    MobName = x.MobName,
                }));
                task.Locations = null;
            }

            builder.Entity<AchievementTask>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasOne(x => x.AchievementType)
                    .WithMany(y => y.AchievementTasks)
                    .HasForeignKey(x => x.AchievementTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AchievementTask_AchievementType");

                e.HasOne(x => x.Category)
                    .WithMany(y => y.AchievementTasks)
                    .HasForeignKey(x => x.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AchievementTask_Category");

                e.HasData(achievementTasks);
            });

            builder.Entity<AchievementReward>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasOne(x => x.RewardType)
                    .WithMany(x => x.AchievementRewards)
                    .HasForeignKey(x => x.RewardTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AchievementReward_RewardType");

                e.HasOne(x => x.Achievement)
                    .WithMany(x => x.Rewards)
                    .HasForeignKey(x => x.AchievementId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AchievementReward_AchievementTask");

                e.HasData(SeedTasks.SeedAchievementRewards(achievementTasks));
            });

            builder.Entity<BLUSpellTask>(e =>
            {
                e.HasKey(x => x.Id);


                e.HasOne(x => x.Category)
                    .WithMany(y => y.BLUSpellTasks)
                    .HasForeignKey(x => x.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BLUSpellTask_Category");

                e.HasData(bluSpellTasks);
            });

            builder.Entity<BLUSpellLocation>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasOne(x => x.Task)
                    .WithMany(x => x.Locations)
                    .HasForeignKey(x => x.BLUSpellTaskId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BLUSpellLocation_BLUSpellTask");

                e.HasData(bluSpellLocations.ToArray());
            });

            builder.Entity<BLUCarnivaleTask>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasOne(x => x.Category)
                    .WithMany(x => x.BLUCarnivaleTasks)
                    .HasForeignKey(x => x.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BLUCarnivaleTask_Category");

                e.HasData(SeedTasks.SeedBLUCarnivaleTasks());
            });

            builder.Entity<BLULogTask>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasOne(x => x.Category)
                    .WithMany(x => x.BLULogTasks)
                    .HasForeignKey(x => x.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BLULogTask_Category");

                e.HasOne(x => x.Content)
                    .WithMany(x => x.BLULogTasks)
                    .HasForeignKey(x => x.ContentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BLULogTask_PvEContent");

                e.HasData(SeedTasks.SeedBLULogTasks());
            });

            builder.Entity<CollectionTask>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasOne(x => x.Category)
                    .WithMany(x => x.CollectionTasks)
                    .HasForeignKey(x => x.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CollectionTask_Category");

                e.HasOne(x => x.CollectionType)
                    .WithMany(x => x.CollectionTasks)
                    .HasForeignKey(x => x.CollectionTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CollectionTask_CollectionType");

                e.HasData(SeedTasks.SeedCollectionTasks());
            });

            builder.Entity<CraftingLogTask>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasOne(x => x.Category)
                    .WithMany(x => x.CraftingLogTasks)
                    .HasForeignKey(x => x.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CraftingLogTask_Category");

                e.HasOne(x => x.CraftingLogType)
                    .WithMany(x => x.CraftingLogTasks)
                    .HasForeignKey(x => x.CraftingLogTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CraftingLogTask_CraftingLogType");

                e.HasData(SeedTasks.SeedCraftingLogTasks());
            });

            builder.Entity<FATETask>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasOne(x => x.Category)
                    .WithMany(x => x.FATETasks)
                    .HasForeignKey(x => x.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FATETask_Category");

                using (var seed = new FATESeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<FishGuideTask>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasOne(x => x.Category)
                    .WithMany(x => x.FishGuideTasks)
                    .HasForeignKey(x => x.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FishGuideTasks_Category");

                e.HasOne(x => x.Zone)
                    .WithMany(x => x.FishGuideTasks)
                    .HasForeignKey(x => x.ZoneId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FishGuideTask_Zone");

                using (var seed = new FishGuideSeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<GatheringLogTask>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasOne(x => x.Category)
                    .WithMany(x => x.GatheringLogTasks)
                    .HasForeignKey(x => x.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GatheringLogTask_Category");

                e.HasOne(x => x.GatherType)
                    .WithMany(x => x.GatheringLogTasks)
                    .HasForeignKey(x => x.GatherTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GatheringLogTask_GatherType");

                //e.HasOne(x => x.Zone)
                //    .WithMany(x => x.GatheringLogTasks)
                //    .HasForeignKey(x => x.ZoneId)
                //    .OnDelete(DeleteBehavior.Restrict)
                //    .HasConstraintName("FK_GatheringLogTask_Zone");

                using (var seed = new GatheringLogSeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<TheHuntTask>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasOne(x => x.Category)
                    .WithMany(x => x.TheHuntTasks)
                    .HasForeignKey(x => x.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TheHuntTask_Category");

                using (var seed = new TheHuntSeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<LeveTask>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasOne(x => x.Category)
                    .WithMany(x => x.LeveTasks)
                    .HasForeignKey(x => x.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LeveTask_Category");

                e.HasOne(x => x.LeveType)
                    .WithMany(x => x.LeveTasks)
                    .HasForeignKey(x => x.LeveTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LeveTask_LeveType");

                using (var seed = new LeveSeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<HuntingLogTask>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<HuntingLogTask, Entities.Categories.Category>(e, "Category", "HuntingLogTasks", "CategoryId");
                CreateOneToMany<HuntingLogTask, HuntingLogType>(e, "HuntingLogType", "HuntingLogTasks", "HuntingLogTypeId");

                var seed = huntingResults.Select(x => new HuntingLogTask
                {
                    Id = x.Id,
                    CategoryId = x.CategoryId,
                    HuntingLogTypeId = x.HuntingLogTypeId,
                    Level = x.Level,
                    Name = x.Name,
                    Number = x.Number
                });

                e.HasData(seed.ToArray());
            });

            builder.Entity<HuntingLogMob>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<HuntingLogMob, HuntingLogTask>(e, "HuntingLogTask", "Mobs", "HuntingLogId");

                var seed = huntingResults.SelectMany(x => x.Mobs).ToArray();

                e.HasData(seed);
            });

            builder.Entity<MSQTask>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<MSQTask, Entities.Categories.Category>(e, "Category", "MSQTasks", "CategoryId");
                CreateOneToMany<MSQTask, MSQType>(e, "MSQType", "MSQTasks", "MSQTypeId");

                using (var seed = new MSQSeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<OrchestrionTask>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<OrchestrionTask, Entities.Categories.Category>(e, "Category", "OrchestrionTasks", "CategoryId");
                CreateOneToMany<OrchestrionTask, OrchestrionType>(e, "OrchestrionType", "OrchestrionTasks", "OrchestrionTypeId");

                using (var seed = new OrchestrionSeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<PvETask>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<PvETask, Entities.Categories.Category>(e, "Category", "PvETasks", "CategoryId");
                CreateOneToMany<PvETask, PvEContent>(e, "Content", "PvETasks", "ContentId");

                using (var seed = new PvESeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<SightseeingLogTask>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<SightseeingLogTask, Entities.Categories.Category>(e, "Category", "SightseeingTasks", "CategoryId");
                CreateOneToMany<SightseeingLogTask, Patch>(e, "Patch", "SightseeingTasks", "PatchId");

                using (var seed = new SightseeingSeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<CardTask>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<CardTask, Entities.Categories.Category>(e, "Category", "CardTasks", "CategoryId");

                using (var seed = new CardSeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<OpponentTask>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<OpponentTask, Entities.Categories.Category>(e, "Category", "OpponentTasks", "CategoryId");

                using (var seed = new OpponentSeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<BeastQuestTask>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<BeastQuestTask, Entities.Categories.Category>(e, "Category", "BeastQuestTasks", "CategoryId");
                CreateOneToMany<BeastQuestTask, BeastTribe>(e, "BeastTribe", "BeastQuestTasks", "BeastTribeId");
                CreateOneToMany<BeastQuestTask, BeastRank>(e, "BeastRank", "BeastQuestTasks", "BeastRankId");

                using (var seed = new BeastTribeSeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<ClassQuestTask>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<ClassQuestTask, Entities.Categories.Category>(e, "Category", "ClassQuestTasks", "CategoryId");
                CreateOneToMany<ClassQuestTask, Discipline>(e, "Discipline", "ClassQuestTasks", "DisciplineId");

                using (var seed = new ClassQuestSeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<SQTask>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<SQTask, Entities.Categories.Category>(e, "Category", "SidequestTasks", "CategoryId");
                CreateOneToMany<SQTask, SQType>(e, "SQType", "SidequestTasks", "SQTypeId");

                using (var seed = new SidequestSeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<RoleQuestTask>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<RoleQuestTask, Entities.Categories.Category>(e, "Category", "RoleQuestTasks", "CategoryId");
                CreateOneToMany<RoleQuestTask, JobRole>(e, "JobRole", "RoleQuestTasks", "JobRoleId");

                using (var seed = new RoleQuestSeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<RelicWeaponTask>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<RelicWeaponTask, Entities.Categories.Category>(e, "Category", "RelicWeaponTasks", "CategoryId");
                CreateOneToMany<RelicWeaponTask, Discipline>(e, "Discipline", "RelicWeaponTasks", "DisciplineId");

                using (var seed = new RelicWeaponSeed())
                    e.HasData(seed.Seed());
            });

            builder.Entity<UserTask>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<UserTask, AppUser>(e, "User", "UserTasks", "UserId");
                CreateOneToMany<UserTask, Entities.Categories.Category>(e, "Category", "UserTasks", "CatregoryId");
            });
        }

        ReferenceCollectionBuilder CreateOneToMany<EntityType, OneType>(EntityTypeBuilder<EntityType> builder, string oneName,
            string manyName, string foreignKey, DeleteBehavior deleteBehavior = DeleteBehavior.Restrict) where EntityType : class where OneType : class
        {
            return builder.HasOne<OneType>(oneName)
                .WithMany(manyName)
                .HasForeignKey(foreignKey)
                .OnDelete(deleteBehavior)
                .HasConstraintName(string.Format("FK_{0}_{1}", oneName, manyName));
        }
    }
}
