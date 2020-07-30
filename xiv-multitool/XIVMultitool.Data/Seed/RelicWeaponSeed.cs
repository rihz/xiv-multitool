using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Tasks.Collections;

namespace XIVChecklist.Data.Seed
{
    public class RelicWeaponSeedling : Seedling
    {
        public string Category { get; set; }

        public RelicWeaponSeedling(string name, string category)
            : base(name, category)
        {
            Category = category;
        }
    }

    public class RelicWeaponSeed : Seed<RelicWeaponTask>, ISeed<RelicWeaponTask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return new Seedling[]
                {
                    new RelicWeaponSeedling("Relic Weapons - Zodiac", "Zodiac"),
                    new RelicWeaponSeedling("Relic Weapons - Anima", "Anima"),
                    new RelicWeaponSeedling("Relic Weapons - Eurekan", "Eurekan")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("Collections", name);
        }

        public IEnumerable<RelicWeaponTask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<RelicWeaponTask>();
            var ctr = id;
            var sdling = ((RelicWeaponSeedling)seedling);
            
            switch(sdling.Category.ToLower())
            {
                case "zodiac":
                    var zParse = ParseResource<ZodiacWeaponParse>(resource);

                    foreach(var z in zParse)
                    {
                        tasks.AddRange(
                            CreateRelicWeaponTasks(
                                ref ctr, 
                                seedling.CategoryId, 
                                SeedCommon.GetDisciplineIdByAbbreviation(z.Discipline),
                                z.FirstName,
                                z.SecondName
                            )
                        );
                    }
                    break;
                case "anima":
                    var aParse = ParseResource<AnimaWeaponParse>(resource);

                    foreach(var a in aParse)
                    {
                        tasks.AddRange(
                            CreateRelicWeaponTasks(
                                ref ctr,
                                seedling.CategoryId,
                                SeedCommon.GetDisciplineIdByAbbreviation(a.Discipline),
                                a.FirstName,
                                a.SecondName,
                                a.ThirdName,
                                a.FourthName
                            )
                        );
                    }
                    break;
                case "eurekan":
                    var eParse = ParseResource<EurekanWeaponParse>(resource);

                    foreach(var e in eParse)
                    {
                        tasks.AddRange(
                            CreateRelicWeaponTasks(
                                ref ctr,
                                seedling.CategoryId,
                                SeedCommon.GetDisciplineIdByAbbreviation(e.Discipline),
                                e.AnemosName,
                                string.Concat("Elemental ", e.ElementalPyrosName),
                                e.PhyseosName
                            )
                        );
                    }
                    break;
                default:
                    break;
            }

            id = ctr;

            return tasks;
        }

        public RelicWeaponTask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }

        IEnumerable<RelicWeaponTask> CreateRelicWeaponTasks(ref int id, int categoryId, int disciplineId, params string[] names)
        {
            var list = new List<RelicWeaponTask>();

            foreach(var name in names)
            {
                list.Add(new RelicWeaponTask
                {
                    Id = ++id,
                    Name = name,
                    CategoryId = categoryId,
                    DisciplineId = disciplineId
                });
            }

            return list;
        }
    }
}
