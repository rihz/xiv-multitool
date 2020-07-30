using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XIVChecklist.Api.Controllers.Tasks;

namespace XIVChecklist.Api.Controllers.Categories
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
        public int Position { get; set; }
        
        public List<CategoryModel> Categories { get; set; }
        public List<ITaskModel> Tasks { get; set; }
    }
}
