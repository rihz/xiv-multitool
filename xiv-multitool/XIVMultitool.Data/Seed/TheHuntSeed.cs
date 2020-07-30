using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Tasks;

namespace XIVChecklist.Data.Seed
{
    public class TheHuntSeedling : Seedling
    {
        public TheHuntSeedling(string name, string childCategory)
            : base(name, "The Hunt", childCategory)
        { }
    }

    public class TheHuntSeed : Seed<TheHuntTask>, ISeed<TheHuntTask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return new Seedling[]
                {
                    new TheHuntSeedling("ARR", "A Realm Reborn"),
                    new TheHuntSeedling("HW", "Heavensward"),
                    new TheHuntSeedling("SB", "Stormblood"),
                    new TheHuntSeedling("ShB", "Shadowbringers")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("Hunt", name);
        }

        public IEnumerable<TheHuntTask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<TheHuntTask>();
            var ctr = id;
            var parse = ParseResource<TheHuntParse>(resource);

            tasks.AddRange(parse.Select((x, index) =>
            {
                return new TheHuntTask
                {
                    Id = ++ctr,
                    Name = x.Name,
                    CategoryId = seedling.CategoryId,
                    Location = x.Location,
                    Rank = x.Rank
                };
            }));

            id = ctr;

            return tasks;
        }

        public TheHuntTask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
