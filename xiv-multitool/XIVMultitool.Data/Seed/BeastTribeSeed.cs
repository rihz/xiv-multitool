using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Common;
using XIVChecklist.Entities.Tasks.SQ;

namespace XIVChecklist.Data.Seed
{
    public class BeastTribeSeedling : Seedling
    {
        public BeastTribeSeedling(string name)
            : base(name)
        { }
    }

    public class BeastTribeSeed : Seed<BeastQuestTask>, ISeed<BeastQuestTask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return new Seedling[]
                {
                    new BeastTribeSeedling("Beast Tribe")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("SQ", name);
        }

        public IEnumerable<BeastQuestTask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<BeastQuestTask>();
            var ctr = id;
            var parse = ParseResource<BeastQuestParse>(resource);

            tasks.AddRange(parse.Select((x, index) =>
            {
                return new BeastQuestTask
                {
                    Id = ++ctr,
                    Name = x.Name,
                    Level = int.Parse(x.Level),
                    BeastRankId = SeedCommon.BeastRanks.GetMatchId<BeastRank>(x.Rank),
                    BeastTribeId = SeedCommon.BeastTribes.GetMatchId<BeastTribe>(x.Tribe),
                    CategoryId = SeedCategories.GetCategoryId(x.Tribe)
                };
            }));

            id = ctr;

            return tasks;
        }
                                                                                                                                                                                                                                                                    
        public BeastQuestTask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
