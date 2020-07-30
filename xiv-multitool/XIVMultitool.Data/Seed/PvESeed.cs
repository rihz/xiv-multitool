using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Tasks.PvE;

namespace XIVChecklist.Data.Seed
{
    public class PvESeedling : Seedling
    {
        public PvESeedling(string name)
            : base(name, "PvE")
        { }
    }

    public class PvESeed : Seed<PvETask>, ISeed<PvETask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return new Seedling[]
                {
                    new PvESeedling("Dungeons"),
                    new PvESeedling("Guildhests"),
                    new PvESeedling("Raids"),
                    new PvESeedling("Trials")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("PvE", name);
        }

        public IEnumerable<PvETask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<PvETask>();
            var ctr = id;
            var parse = ParseResource<PvEParse>(resource);

            tasks.AddRange(parse.Select((x, index) =>
            {
                return new PvETask
                {
                    Id = ++ctr,
                    Name = x.Name,
                    CategoryId = seedling.CategoryId,
                    ContentId = SeedCommon.GetContentId(x.Name)
                };
            }));

            id = ctr;

            return tasks;
        }

        public PvETask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
