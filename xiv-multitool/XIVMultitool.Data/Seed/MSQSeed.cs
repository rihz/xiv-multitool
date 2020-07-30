using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Tasks.MSQ;

namespace XIVChecklist.Data.Seed
{
    public class MSQSeedling : Seedling
    {
        public string MSQTypeName { get; set; }

        public MSQSeedling(string name, string typeName = "")
            : base(name, "MSQ", typeName != "" ? typeName : name)
        {
            MSQTypeName = typeName != "" ? typeName : name;
        }
    }

    public class MSQSeed : Seed<MSQTask>, ISeed<MSQTask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return new Seedling[]
                {
                    new MSQSeedling("Dragonsong War"),
                    new MSQSeedling("Heavensward"),
                    new MSQSeedling("Legend Returns", "The Legend Returns"),
                    new MSQSeedling("Post-Shadowbringers"),
                    new MSQSeedling("Seventh Astral", "Seventh Astral Era"),
                    new MSQSeedling("Seventh Umbral", "Seventh Umbral Era"),
                    new MSQSeedling("Shadowbringers"),
                    new MSQSeedling("Shadowbringers"),
                    new MSQSeedling("Stormblood")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("MSQ", name);
        }

        public IEnumerable<MSQTask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<MSQTask>();
            var ctr = id;
            var parse = ParseResource<MSQTaskParse>(resource);

            tasks.AddRange(parse.Select((x, index) =>
            {
                var task = new MSQTask
                {
                    Id = ++ctr,
                    Name = x.Name,
                    CategoryId = seedling.CategoryId,
                    MSQTypeId = SeedCommon.GetMSQTypeId(((MSQSeedling)seedling).MSQTypeName),
                    Level = x.Level,
                };

                return task;
            }));

            id = ctr;

            return tasks;
        }

        public MSQTask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
