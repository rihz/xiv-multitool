using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using XIVChecklist.Entities.Common;
using XIVChecklist.Entities.Tasks;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Data.Extensions;

namespace XIVChecklist.Data.Seed
{
    public static class SeedTasks
    {        
        public static AchievementTask[] SeedAchievementTasks()
        {
            var tasks = new List<AchievementTask>();
            var id = 0;
            
            foreach (var seed in AchievementSeedling.Seedlings)
            {
                var resource = SeedHelper.GetAchievementResource(seed.FileName);

                var parse = Parse<AchievementTask>(resource);

                tasks.AddRange(parse.Select((x, index) => new AchievementTask
                {
                    Id = ++id,
                    Name = x.Name,
                    Description = x.Description,
                    AchievementTypeId = seed.AchievementTypeId,
                    CategoryId = seed.CategoryId,
                    Points = x.Points,
                    Reward = x.Reward
                }).ToList());
            }

            return tasks.ToArray();
        }

        public static AchievementReward[] SeedAchievementRewards(AchievementTask[] tasks)
        {
            var rewards = new List<AchievementReward>();
            var id = 0;

            foreach (var task in tasks)
            {
                var split = SplitReward(task.Reward);

                for (int i = 0; i < split.Length; i += 2)
                {
                    if (split.Length >= 2)
                    {
                        var rtype = split[i];
                        var rwd = DelimitReward(split[i + 1]);

                        var rwds = rwd.Select(x => new AchievementReward
                        {
                            Id = ++id,
                            AchievementId = task.Id,
                            RewardTypeId = SeedCommon.GetRewardTypeId(rtype),
                            Reward = x
                        });

                        rewards.AddRange(rwds);
                    }
                }
            }

            return rewards.ToArray();
        }

        public static BLUSpellTask[] SeedBLUSpellTasks()
        {
            var tasks = new List<BLUSpellTask>();
            var id = 0;
            var locationId = 0;

            foreach(var seed in BLUSpellSeedling.Seedlings)
            {
                var resource = SeedHelper.GetBLUResource(seed.FileName);

                var parse = Parse<BLUSpellParse>(resource);

                tasks.AddRange(parse.Select((x, index) => new BLUSpellTask
                {
                    Id = ++id,
                    Name = x.Name,
                    CategoryId = seed.CategoryId,
                    Number = x.Number,
                    Locations = ParseSpellLocations(x.Location, x.Mobs, id, ++locationId)
                }));
            }

            return tasks.ToArray();
        }

        public static BLUCarnivaleTask[] SeedBLUCarnivaleTasks()
        {
            var tasks = new List<BLUCarnivaleTask>();
            var id = 0;

            foreach(var seed in BLUCarnivaleSeedling.Seedlings)
            {
                var resource = SeedHelper.GetBLUResource(seed.FileName);

                var parse = Parse<BLUCarnivaleParse>(resource);

                tasks.AddRange(parse.Select((x, index) => new BLUCarnivaleTask
                {
                    Id = ++id,
                    CategoryId = seed.CategoryId,
                    Name = x.Name,
                    Stage = x.Stage,
                    StandardMinute = x.Standard.Split(':')[0],
                    StandardSecond = x.Standard.Split(':')[1],
                    IdealMinute = x.Ideal.Split(':')[0],
                    IdealSecond = x.Ideal.Split(':')[1],
                }));
            }

            return tasks.ToArray();
        }

        public static BLULogTask[] SeedBLULogTasks()
        {
            var tasks = new List<BLULogTask>();
            var id = 0;

            foreach(var seed in BLULogSeedling.Seedlings)
            {
                var resource = SeedHelper.GetBLUResource(seed.FileName);

                var parse = Parse<BLULogParse>(resource);

                tasks.AddRange(parse.Select((x, index) => new BLULogTask
                {
                    Id = ++id,
                    CategoryId = seed.CategoryId,
                    ContentId = SeedCommon.GetContentId(x.Content),
                    Name = x.Name
                }));
            }

            return tasks.ToArray();
        }

        public static T[] Seed<T>(Seedling[] seedlings, Func<string, Stream> GetResource, ParseTasks<T> ParseTasks) where T : ITask
        {
            var tasks = new List<T>();
            var id = 0;

            foreach(var seed in seedlings)
            {
                var resource = SeedHelper.GetCollectionResource(seed.FileName);

                tasks.AddRange(ParseTasks(resource, seed, ref id));
            }

            return tasks.ToArray();
        }

        public delegate IEnumerable<T> ParseTasks<T>(Stream resource, Seedling seedling, ref int id) where T : ITask;

        public static IEnumerable<CollectionTask> ParseCollectionTasks(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<CollectionTask>();
            var ctr = id;
            var parse = Parse<CollectionParse>(resource);

            tasks.AddRange(parse.Select((x, index) => new CollectionTask
            {
                Id = ++ctr,
                CategoryId = seedling.CategoryId,
                CollectionTypeId = SeedCommon.GetCollectionTypeIndex(seedling.FileName),
                Name = x.Name,
                Method = x.Method
            }));

            id = ctr;

            return tasks;
        }

        public static CollectionTask[] SeedCollectionTasks()
        {
            return Seed(CollectionSeedling.Seedlings, SeedHelper.GetAchievementResource, ParseCollectionTasks);
        }

        public static CraftingLogTask[] SeedCraftingLogTasks()
        {
            var tasks = new List<CraftingLogTask>();
            var id = 0;

            foreach(var seed in CraftingLogSeedling.Seedlings)
            {
                var resource = SeedHelper.GetCraftingLogResource(seed.FileName);
                
                var parse = Parse<CraftingLogParse>(resource);
                
                tasks.AddRange(parse.Select((x, index) => new CraftingLogTask
                {
                    Id = ++id,
                    CategoryId = seed.CategoryId,
                    CraftingLogTypeId = seed.CraftingLogTypeId,
                    Name = x.Name,
                    Level = x.Level
                }));
            }

            return tasks.ToArray();
        }

        static ICollection<BLUSpellLocation> ParseSpellLocations(string locations, string mobs, int taskId, int locationId)
        {
            var list = new List<BLUSpellLocation>();

            var locationSplit = locations.TrimSplit(',');
            var mobSplit = mobs.TrimSplit(',');

            var counter = locationSplit.Count() >= mobSplit.Count()
                ? locationSplit.Count()
                : mobSplit.Count();
            
            for(var i = 0; i < counter; i++)
            {
                if(mobSplit.Length >= i + 1)
                {
                    list.Add(new BLUSpellLocation
                    {
                        Id = locationId,
                        BLUSpellTaskId = taskId,
                        LocationName = locationSplit[i],
                        MobName = mobSplit[i]
                    });
                }
            }

            return list;
        }

        static List<T> Parse<T>(Stream resource)
        {
            var parse = new List<T>();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture);
            config.HeaderValidated = null;
            config.MissingFieldFound = null;

            try
            {
                using (var reader = new StreamReader(resource))
                using (var csv = new CsvReader(reader, config))
                {
                    parse = csv.GetRecords<T>()
                        .ToList();
                }

                return parse;
            }
            catch(Exception ex)
            {
                return new List<T>();
            }
        }

        static string[] SplitReward(string reward)
        {
            var result = new List<string>();

            try
            {
                if(reward != null)
                {
                    result.AddRange(reward.Split(':').Select(x => x.Trim()));
                }
            }
            catch (Exception ex)
            {
                Debugger.Launch();
                Console.WriteLine(ex);
            }

            return result.ToArray();
        }

        static string[] DelimitReward(string reward)
        {
            var result = new List<string>();

            try
            {
                if(reward != null)
                {
                    result.AddRange(reward.Split(',').Select(x => x.Trim()));
                }
            }
            catch (Exception ex)
            {
                Debugger.Launch();
                Console.WriteLine(ex);
            }

            return result.ToArray();
        }
    }
}
