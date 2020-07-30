using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace XIVChecklist.Data.Seed
{
    public static class SeedHelper
    {
        const string NAMESPACE = "XIVChecklist.Data.SeedFiles.";
        const string RESOURCE = "{0} - {1}.csv";

        public static Stream GetAchievementResource(string name)
        {
            return GetResource("Achieve", name);
        }

        public static Stream GetBLUResource(string name)
        {
            return GetResource("BLU", name);
        }

        public static Stream GetCollectionResource(string name)
        {
            return GetResource("Collections", name);
        }

        public static Stream GetCraftingLogResource(string name)
        {
            return GetResource("Crafting Logs", name);
        }

        static Assembly Assembly
        {
            get
            {
                return System.Reflection.Assembly.GetExecutingAssembly();
            }
        }

        static Stream GetResource(string name)
        {
            return Assembly.GetManifestResourceStream(NAMESPACE + name);
        }

        static Stream GetResource(string primaryName, string secondaryName)
        {
            return GetResource(string.Format(RESOURCE, primaryName, secondaryName));
        }
    }
}
