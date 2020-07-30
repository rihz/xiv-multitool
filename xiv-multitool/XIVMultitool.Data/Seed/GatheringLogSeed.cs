using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Tasks.Logs;

namespace XIVChecklist.Data.Seed
{
    public class GatheringLogSeedling : Seedling
    {
        public int GatherTypeId { get; set; }

        public GatheringLogSeedling(string name, string parentCategory, string childCategory, string gatherTypeName)
            : base(name, parentCategory, childCategory)
        {
            GatherTypeId = SeedCommon.GetGatherTypeId(gatherTypeName);
        }
    }

    public class GatheringLogSeed : Seed<GatheringLogTask>, ISeed<GatheringLogTask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return new Seedling[]
                {
                    new GatheringLogSeedling("FSH", "Gathering Logs", "Fishing", "Fishing"),
                    new GatheringLogSeedling("Harvesting", "Gathering Logs", "Botanist", "Harvesting"),
                    new GatheringLogSeedling("Logging", "Gathering Logs", "Botanist", "Logging"),
                    new GatheringLogSeedling("Mining", "Gathering Logs", "Mining", "Mining"),
                    new GatheringLogSeedling("Quarrying", "Gathering Logs", "Mining", "Quarrying")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("Gathering Logs", name);
        }

        public IEnumerable<GatheringLogTask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<GatheringLogTask>();
            var ctr = id;
            var parse = ParseResource<GatheringLogParse>(resource);

            tasks.AddRange(parse.Select((x, index) =>
            {
                return new GatheringLogTask
                {
                    Id = ++ctr,
                    Name = x.Name,
                    CategoryId = seedling.CategoryId,
                    Level = x.Level,
                    Location = x.Location,
                    GatherTypeId = ((GatheringLogSeedling)seedling).GatherTypeId
                };
            }));

            id = ctr;

            return tasks;
        }

        public GatheringLogTask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
