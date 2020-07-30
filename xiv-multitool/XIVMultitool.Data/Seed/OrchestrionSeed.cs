using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Tasks;

namespace XIVChecklist.Data.Seed
{
    public class OrchestrionSeedling : Seedling
    {
        public int OrchestrionTypeId { get; set; }

        public OrchestrionSeedling(string name)
            : base(name, "Collections", "Orchestrion")
        {
            OrchestrionTypeId = SeedCommon.GetOrchestrionTypeId(name);
        }

        public static Seedling[] Create(params string[] names)
        {
            var seedlings = new List<Seedling>();

            foreach(var name in names)
            {
                seedlings.Add(new OrchestrionSeedling(name));
            }

            return seedlings.ToArray();
        }
    }

    public class OrchestrionSeed : Seed<OrchestrionTask>, ISeed<OrchestrionTask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return OrchestrionSeedling.Create("Dungeons", "Locales", "Mog Station", "Others", "Raids", "Seasonal", "Trials");
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("Orchestrion", name);
        }

        public IEnumerable<OrchestrionTask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<OrchestrionTask>();
            var ctr = id;
            var parse = ParseResource<OrchestrionParse>(resource);

            tasks.AddRange(parse.Select((x, index) =>
            {
                return new OrchestrionTask
                {
                    Id = ++ctr,
                    Name = x.Name,
                    CategoryId = seedling.CategoryId,
                    Method = x.Method,
                    Number = x.Number,
                    OrchestrionTypeId = ((OrchestrionSeedling)seedling).OrchestrionTypeId
                };
            }));

            id = ctr;

            return tasks;
        }

        public OrchestrionTask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
