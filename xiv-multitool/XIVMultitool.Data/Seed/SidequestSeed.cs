using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Tasks.SQ;

namespace XIVChecklist.Data.Seed
{
    public class SidequestSeedling : Seedling
    {
        public string TypeName { get; set; }

        public SidequestSeedling(string name, string category, string type = null)
            : base(name, category)
        {
            TypeName = type ?? name;
        }
    }

    public class SidequestSeed : Seed<SQTask>, ISeed<SQTask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return new Seedling[]
                {
                    new SidequestSeedling("Abalathia", "Abalathia's Spine"),
                    new SidequestSeedling("Amh Araeng", "Amh Araeng"),
                    new SidequestSeedling("Black Shroud", "Black Shroud"),
                    new SidequestSeedling("Chronicles of a New Era", "Chronicles of a New Era"),
                    new SidequestSeedling("Coerthas", "Coerthas"),
                    new SidequestSeedling("Crystalline Mean", "Crystalline Mean"),
                    new SidequestSeedling("Dravania", "Dravania"),
                    new SidequestSeedling("GC", "Grand Company", "Grand Company"),
                    new SidequestSeedling("Gyr Abania", "Gyr Abania"),
                    new SidequestSeedling("Il Mheg", "Il Mheg"),
                    new SidequestSeedling("Ishgard", "Ishgard"),
                    new SidequestSeedling("Kholusia", "Kholusia"),
                    new SidequestSeedling("Kugane", "Kugane"),
                    new SidequestSeedling("La Noscea", "La Noscea"),
                    new SidequestSeedling("Lakeland", "Lakeland"),
                    new SidequestSeedling("Mor Dhona", "Mor Dhona"),
                    new SidequestSeedling("Othard", "Othard"),
                    new SidequestSeedling("Raktika", "Rak'tika", "Rak'tika"),
                    new SidequestSeedling("Side Story", "Side Story"),
                    new SidequestSeedling("Tempest", "Tempest"),
                    new SidequestSeedling("Thanalan", "Thanalan")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("SQ", name);
        }

        public IEnumerable<SQTask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<SQTask>();
            var ctr = id;
            var parse = ParseResource<SQTaskParse>(resource);

            tasks.AddRange(parse.Select((x, index) =>
            {
                return new SQTask
                {
                    Id = ++ctr,
                    Name = x.Name,
                    CategoryId = seedling.CategoryId,
                    Level = int.Parse(x.Level),
                    SQTypeId = SeedCommon.GetSQTypeId(((SidequestSeedling)seedling).TypeName)
                };
            }));

            id = ctr;

            return tasks;
        }

        public SQTask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
