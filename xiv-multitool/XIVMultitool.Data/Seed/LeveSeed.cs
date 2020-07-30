using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Tasks.PvE;

namespace XIVChecklist.Data.Seed
{
    public class LeveSeedling : Seedling
    {
        public LeveSeedling(string name)
            : base(name, "Levequests", name)
        { }
    }

    public class LeveSeed : Seed<LeveTask>, ISeed<LeveTask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return new Seedling[]
                {
                    new LeveSeedling("Battlecraft"),
                    new LeveSeedling("Fieldcraft"),
                    new LeveSeedling("Tradecraft")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("Leves", name);
        }

        public IEnumerable<LeveTask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<LeveTask>();
            var ctr = id;
            var parse = ParseResource<LeveParse>(resource);

            tasks.AddRange(parse.Select((x, index) =>
            {
                return new LeveTask
                {
                    Id = ++ctr,
                    Name = x.Name,
                    CategoryId = seedling.CategoryId,
                    Level = x.Level,
                    LeveTypeId = SeedCommon.GetLeveTypeId(x.Type),
                    NPCName = x.NPC
                };
            }));

            id = ctr;

            return tasks;
        }

        public LeveTask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
