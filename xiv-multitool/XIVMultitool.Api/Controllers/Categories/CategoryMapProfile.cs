using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XIVChecklist.Api.Controllers.Tasks;
using XIVChecklist.Entities.Categories;

namespace XIVChecklist.Api.Controllers.Categories
{
    public class CategoryMapProfile : Profile
    {
        public CategoryMapProfile()
        {
            CreateMap<Category, CategoryModel>()
                .ForMember(x => x.ParentCategoryId, y => y.MapFrom(z => !z.ParentCategoryId.HasValue ? 0 : z.ParentCategoryId.Value))
                .ForMember(x => x.Categories, y => y.UseValue(new List<CategoryModel>()))
                .ForMember(x => x.Tasks, y => y.UseValue(new List<ITaskModel>()));
        }
    }
}
