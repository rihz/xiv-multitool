using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Tasks.SQ;

namespace XIVChecklist.Data.Seed
{
    public class RoleQuestSeedling : Seedling
    {
        public RoleQuestSeedling(string name)
            : base(name, "Role Quests")
        { }
    }

    public class RoleQuestSeed : Seed<RoleQuestTask>, ISeed<RoleQuestTask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return new RoleQuestSeedling[]
                {
                    new RoleQuestSeedling("Role Quests")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("SQ", name);
        }

        public IEnumerable<RoleQuestTask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<RoleQuestTask>();
            var ctr = id;
            var parse = ParseResource<RoleQuestParse>(resource);

            tasks.AddRange(parse.Select((x, index) =>
            {
                return new RoleQuestTask
                {
                    Id = ++ctr,
                    Name = x.Name,
                    CategoryId = seedling.CategoryId,
                    JobRoleId = SeedCommon.GetJobRoleId(x.Role),
                    Level = int.Parse(x.Level)
                };
            }));

            id = ctr;

            return tasks;
        }

        public RoleQuestTask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
