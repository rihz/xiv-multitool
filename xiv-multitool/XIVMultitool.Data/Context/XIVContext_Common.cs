using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Data.Context
{
    public partial class XIVContext
    {
        public virtual DbSet<AchievementType> AchievementType { get; set; }
        public virtual DbSet<BeastRank> BeastRank { get; set; }
        public virtual DbSet<BeastTribe> BeastTribe { get; set; }
        public virtual DbSet<CollectionType> CollectionType { get; set; }
        public virtual DbSet<CraftingLogType> CraftingLogType { get; set; }
        public virtual DbSet<Discipline> Discipline { get; set; }
        public virtual DbSet<Expansion> Expansion { get; set; }
        public virtual DbSet<FATEType> FATEType { get; set; }
        public virtual DbSet<GatherType> GatherTypes { get; set; }
        public virtual DbSet<HuntingLogType> HuntingLogTypes { get; set; }
        public virtual DbSet<JobRole> JobRole { get; set; }
        public virtual DbSet<LeveType> LeveType { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<MSQType> MSQType { get; set; }
        public virtual DbSet<OrchestrionType> OrchestrionType { get; set; }
        public virtual DbSet<Patch> Patch { get; set; }
        public virtual DbSet<PvEContent> PvEContent { get; set; }
        public virtual DbSet<PvEContentType> PvEContentType { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RewardType> RewardType { get; set; }
        public virtual DbSet<SightseeingEmote> SightseeingEmote { get; set; }
        public virtual DbSet<SQType> SQType { get; set; }
        public virtual DbSet<Weather> Weather { get; set; }
        public virtual DbSet<Zone> Zone { get; set; }

        public void OnModelCreating_Common(ModelBuilder builder)
        {
            builder.Entity<AchievementType>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.GetSeed<AchievementTypeEnum>());
            });

            builder.Entity<BeastRank>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.BeastRanks.SelectArray<BeastRank>());
            });

            builder.Entity<BeastTribe>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.BeastTribes.SelectArray<BeastTribe>());
            });

            builder.Entity<CollectionType>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.CollectionTypes.SelectArray<CollectionType>());
            });

            builder.Entity<CraftingLogType>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.CraftingLogTypes.SelectArray<CraftingLogType>());
            });

            builder.Entity<Discipline>(e =>
            {
                e.HasKey(x => x.Id);

                var data = new List<Discipline>();

                for (int i = 0; i < SeedCommon.DisciplineNames.Length; i++)
                {
                    data.Add(
                        new Discipline
                        {
                            Id = i + 1,
                            Name = SeedCommon.DisciplineNames[i],
                            Abbreviation = SeedCommon.DisciplineAbbrevs[i]
                        }
                    );
                }

                e.HasData(data.ToArray());
            });

            builder.Entity<Expansion>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(
                    new Expansion { Id = 1, Name = "A Realm Reborn" },
                    new Expansion { Id = 2, Name = "Heavensward" },
                    new Expansion { Id = 3, Name = "Stormblood" },
                    new Expansion { Id = 4, Name = "Shadowbringers" }
                );
            });

            builder.Entity<FATEType>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.FATETypes.SelectArray<FATEType>());
            });

            builder.Entity<GatherType>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.GatherTypes);
            });

            builder.Entity<HuntingLogType>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.HuntingLogTypes.SelectArray<HuntingLogType>());
            });

            builder.Entity<JobRole>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(
                    SeedCommon.JobRoles.SelectArray<JobRole>()
                );
            });

            builder.Entity<LeveType>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(
                    SeedCommon.LeveTypes
                );
            });

            builder.Entity<MSQType>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.MSQTypes.SelectArray<MSQType>());
            });

            builder.Entity<OrchestrionType>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.OrchestrionTypes.SelectArray<OrchestrionType>());
            });

            builder.Entity<Patch>(e =>
            {
                e.HasKey(x => x.Id);
                
                e.HasData(SeedCommon.Patches);
            });

            builder.Entity<PvEContentType>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.ContentTypes.ToArray());
            });

            builder.Entity<PvEContent>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.GetPvEContent().ToArray());
            });

            builder.Entity<Region>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.Regions.ToArray());
            });

            builder.Entity<RewardType>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.RewardTypes);
            });

            builder.Entity<SQType>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.SQTypes.SelectArray<SQType>());
            });

            builder.Entity<Zone>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasData(SeedCommon.GetZones().ToArray());
            });
        }
    }
}
