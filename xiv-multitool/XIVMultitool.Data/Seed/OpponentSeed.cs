using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Tasks;

namespace XIVChecklist.Data.Seed
{
    public class OpponentSeedling : Seedling
    {
        public OpponentSeedling(string name)
            : base(name, "Opponents")
        { }
    }

    public class OpponentSeed : Seed<OpponentTask>, ISeed<OpponentTask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return new Seedling[]
                {
                    new OpponentSeedling("Opponents")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("Triple Triad", name);
        }

        public IEnumerable<OpponentTask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<OpponentTask>();
            var ctr = id;
            var parse = ParseResource<OpponentParse>(resource);

            tasks.AddRange(parse.Select((x, index) =>
            {
                return new OpponentTask
                {
                    Id = ++ctr,
                    Name = x.Name,
                    CategoryId = seedling.CategoryId,
                    Location = x.Location,
                    Zone = x.Zone
                };
            }));

            id = ctr;

            return tasks;
        }

        public OpponentTask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
