using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XIVChecklist.Api.Controllers.Tasks;
using XIVChecklist.Api.Controllers.Tasks.Enums;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;
using XIVChecklist.Entities.Tasks;

namespace XIVChecklist.Api.Extensions
{
    public static class Extensions 
    {
        static readonly int MAX_CATEGORY_POSITION = 3;

        public static IEnumerable<Category> Combine(this IEnumerable<Category> categories)
        {
            var combined = new List<Category>();

            //var groups = categories.GroupBy(x => x.ParentCategoryId);
            //var parentCategories = groups.First(a => a.Key == null).ToList();
            //var childCategories = groups.Where(a => a.Key != null)
            //    .OrderByDescending(x => x.Key);

            for (int i  = MAX_CATEGORY_POSITION; i > 1; i--)
            {
                var positionCategories = categories.Where(a => a.Position == i);

                foreach(var category in positionCategories)
                {
                    var parent = categories.First(a => a.Id == category.ParentCategoryId);

                    if(parent.ChildCategories == null)
                    {
                        parent.ChildCategories = new List<Category>()
                        {
                            category
                        };
                    }
                    else
                    {
                        parent.ChildCategories.Add(category);
                    }
                }
            }

            combined.AddRange(
                categories.Where(x => x.ParentCategoryId == null)
            );

            //parentCategories = parentCategories.Select(x => x.ResetParentCategory())
            //    .OrderByDescending(x => x.ParentCategoryId)
            //    .ToList();

            return combined;
        }

        public static int SearchId(this IEnumerable<ICommon> list, string name)
        {
            try
            {
                return list.First(x => x.Name.ToLower() == name.ToLower()).Id;
            }
            catch(Exception ex)
            {
                return -1;
            }
        }
    }
}
