using System;
using System.Collections.Generic;
using System.Text;

namespace XIVChecklist.Data.Seed.Seedlings
{
    public abstract class Seedling
    {
        public string FileName { get; set; }
        public int CategoryId { get; set; }

        public Seedling(string filename)
        {
            FileName = filename;
        }

        public Seedling(string filename, string category)
        {
            FileName = filename;
            CategoryId = SeedCategories.GetCategoryId(category);
        }

        public Seedling(string filename, string parentCategory, string childCategory)
        {
            FileName = filename;
            CategoryId = SeedCategories.GetCategoryId(parentCategory, childCategory);
        }
    }
}
