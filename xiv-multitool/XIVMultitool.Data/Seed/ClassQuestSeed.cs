using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Tasks.SQ;

namespace XIVChecklist.Data.Seed
{
    public class ClassQuestSeedling : Seedling
    {
        public string ParentCategory { get; set; }

        public ClassQuestSeedling(string name, string parentCategory)
            : base(name)
        {
            ParentCategory = parentCategory;
        }
    }

    public class ClassQuestSeed : Seed<ClassQuestTask>, ISeed<ClassQuestTask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return new ClassQuestSeedling[]
                {
                    new ClassQuestSeedling("Class Quests", "Class Quests"),
                    new ClassQuestSeedling("Job Quests", "Job Quests")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("SQ", name);
        }

        public IEnumerable<ClassQuestTask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<ClassQuestTask>();
            var ctr = id;
            var parse = ParseResource<ClassQuestParse>(resource);

            tasks.AddRange(parse.Select((x, index) =>
            {
                return new ClassQuestTask
                {
                    Id = ++ctr,
                    Name = x.Name,
                    CategoryId = SeedCategories
                        .GetCategoryId(
                            ((ClassQuestSeedling)seedling).ParentCategory, x.Discipline
                        ),
                    Level = int.Parse(x.Level),
                    DisciplineId = SeedCommon.GetDisciplineId(x.Discipline)
                };
            }));

            id = ctr;

            return tasks;
        }

        public ClassQuestTask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
