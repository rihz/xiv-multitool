using System;
using System.Collections.Generic;
using System.Text;

namespace XIVChecklist.Data.Seed.Seedlings
{
    public class BLUSpellSeedling
    {
        public string FileName { get; set; }
        public int CategoryId { get; set; }

        public BLUSpellSeedling(string name, string category)
        {
            FileName = name;
            CategoryId = SeedCategories.GetCategoryId(category);
        }

        public static BLUSpellSeedling[] Seedlings = new BLUSpellSeedling[]
        {
            new BLUSpellSeedling("Spellbook", "Spellbook")
        };
    }

    public class BLULogSeedling
    {
        public string FileName { get; set; }
        public int CategoryId { get; set; }

        public BLULogSeedling(string name, string category)
        {
            FileName = name;
            CategoryId = SeedCategories.GetCategoryId(category);
        }

        public static BLULogSeedling[] Seedlings = new BLULogSeedling[]
        {
            new BLULogSeedling("Log", "BLU Log")
        };
    }

    public class BLUCarnivaleSeedling
    {
        public string FileName { get; set; }
        public int CategoryId { get; set; }

        public BLUCarnivaleSeedling(string name, string category)
        {
            FileName = name;
            CategoryId = SeedCategories.GetCategoryId(category);
        }

        public static BLUCarnivaleSeedling[] Seedlings = new BLUCarnivaleSeedling[]
        {
            new BLUCarnivaleSeedling("Masked Carnivale", "Masked Carnivale")
        };
    }
}
