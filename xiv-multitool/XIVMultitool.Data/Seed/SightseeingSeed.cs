using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Tasks.GameLogs;

namespace XIVChecklist.Data.Seed
{
    public class SightseeingSeedling : Seedling
    {
        public SightseeingSeedling(string name)
            : base(name, "Sightseeing Logs")
        { }
    }

    public class SightseeingSeed : Seed<SightseeingLogTask>, ISeed<SightseeingLogTask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return new Seedling[]
                {
                    new SightseeingSeedling("Sightseeing")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("Logs", name);
        }

        public IEnumerable<SightseeingLogTask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<SightseeingLogTask>();
            var ctr = id;
            var parse = ParseResource<SightseeingLogParse>(resource);

            tasks.AddRange(parse.Select((x, index) =>
            {
                var task = new SightseeingLogTask
                {
                    Id = ++ctr,
                    Name = x.Name,
                    Number = x.Number,
                    Weather = x.Weather,
                    Time = x.Time,
                    Emote = x.Emote,
                    CategoryId = seedling.CategoryId,
                    PatchId = SeedCommon.GetMajorPatchId(x.Set)
                };

                return task;
            }));

            id = ctr;

            return tasks;
        }

        public SightseeingLogTask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
