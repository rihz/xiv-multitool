using System;
using System.Collections.Generic;
using System.Text;

namespace XIVChecklist.Data.Seed.Seedlings
{
    public class CraftingLogSeedling
    {
        public string FileName { get; set; }
        public int CategoryId { get; set; }
        public int CraftingLogTypeId { get; set; }

        public CraftingLogSeedling(string name, string parentCategory, string childCategory)
        {
            FileName = name;
            CategoryId = SeedCategories.GetCategoryId(parentCategory, childCategory);
            CraftingLogTypeId = SeedCommon.GetCraftingLogTypeIndex(name);
        }

        public static CraftingLogSeedling[] Seedlings = new CraftingLogSeedling[]
        {
            new CraftingLogSeedling("ALC", "Crafting Logs", "Alchemist"),
            new CraftingLogSeedling("ARM", "Crafting Logs", "Armorer"),
            new CraftingLogSeedling("BSM", "Crafting Logs", "Blacksmith"),
            new CraftingLogSeedling("CRP", "Crafting Logs", "Carpenter"),
            new CraftingLogSeedling("CUL", "Crafting Logs", "Culinarian"),
            new CraftingLogSeedling("GSM", "Crafting Logs", "Goldsmith"),
            new CraftingLogSeedling("LTW", "Crafting Logs", "Leatherworker"),
            new CraftingLogSeedling("Shared", "Crafting Logs", "Shared"),
            new CraftingLogSeedling("WVR", "Crafting Logs", "Weaver")
        };
    }
}
