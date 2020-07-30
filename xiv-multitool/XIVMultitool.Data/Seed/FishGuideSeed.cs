using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Tasks.Logs;

namespace XIVChecklist.Data.Seed
{
    public class FishGuideSeedling : Seedling
    {
        public FishGuideSeedling(string name, string category)
            : base(name, category)
        { }
    }

    public class FishGuideSeed : Seed<FishGuideTask>, ISeed<FishGuideTask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return new Seedling[]
                {
                    new FishGuideSeedling("Fish Guide", "Fish Guide")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("Gathering Logs", name);
        }

        public IEnumerable<FishGuideTask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<FishGuideTask>();
            var ctr = id;
            var parse = ParseResource<FishGuideParse>(resource);

            tasks.AddRange(parse.Select((x, index) =>
            {
                return new FishGuideTask
                {
                    Id = ++ctr,
                    CategoryId = seedling.CategoryId,
                    Name = x.Name,
                    Bait = x.Bait,
                    ILevel = x.Level,
                    ZoneId = SeedCommon.GetZoneId(x.Zone)
                };
            }));

            return tasks;
        }

        public FishGuideTask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
