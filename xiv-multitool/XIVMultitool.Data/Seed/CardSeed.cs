using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Tasks.Triple_Triad;

namespace XIVChecklist.Data.Seed
{
    public class CardSeedling : Seedling
    {
        public CardSeedling(string name)
            : base(name, "Cards")
        { }
    }

    public class CardSeed : Seed<CardTask>, ISeed<CardTask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return new Seedling[]
                {
                    new CardSeedling("Card")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("Triple Triad", name);
        }

        public IEnumerable<CardTask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<CardTask>();
            var ctr = id;
            var parse = ParseResource<CardParse>(resource);

            tasks.AddRange(parse.Select((x, index) =>
            {
                return new CardTask
                {
                    Id = ++ctr,
                    Name = x.Name,
                    NPCName = x.NPC,
                    CategoryId = seedling.CategoryId,
                    OtherMethods = x.OtherMethods,
                    Rank = int.Parse(x.Rank)
                };
            }));

            id = ctr;

            return tasks;
        }

        public CardTask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
