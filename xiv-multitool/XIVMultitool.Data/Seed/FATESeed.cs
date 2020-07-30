using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Tasks.PvE;

namespace XIVChecklist.Data.Seed
{
    public class FATESeedling : Seedling
    {
        public FATESeedling(string name)
            : base(name, name)
        { }
    }

    public class FATESeed : Seed<FATETask>, ISeed<FATETask>
    {
        public Stream Resource { get; set; }

        public Seedling[] Seedlings
        {
            get
            {
                return new Seedling[]
                {
                    new FATESeedling("Abalathia"),
                    new FATESeedling("Black Shroud"),
                    new FATESeedling("Coerthas"),
                    new FATESeedling("Dravania"),
                    new FATESeedling("Eureka"),
                    new FATESeedling("Gyr Abania"),
                    new FATESeedling("La Noscea"),
                    new FATESeedling("Mor Dhona"),
                    new FATESeedling("Norvrandt"),
                    new FATESeedling("Othard"),
                    new FATESeedling("Thanalan"),
                    new FATESeedling("The Diadem")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("FATEs", name);
        }

        public IEnumerable<FATETask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<FATETask>();
            var ctr = id;
            var parse = ParseResource<FATEParse>(resource);

            tasks.AddRange(parse.Select((x, index) =>
            {
                var location = SplitLocation(x.Location);

                return new FATETask
                {
                    Id = ++ctr,
                    CategoryId = seedling.CategoryId,
                    Name = x.Name,
                    Level = x.Level,
                    Location = location.Name,
                    X = location.Coordinates != null ? location.Coordinates.X : -1.0M,
                    Y = location.Coordinates != null ? location.Coordinates.Y : -1.0M
                };
            }));

            id = ctr;

            return tasks;
        }

        public FATETask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
