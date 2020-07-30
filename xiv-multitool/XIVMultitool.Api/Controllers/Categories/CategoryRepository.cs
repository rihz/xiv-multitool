using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XIVChecklist.Data.Context;
using Microsoft.EntityFrameworkCore;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Api.Controllers.Tasks;
using XIVChecklist.Api.Extensions;

namespace XIVChecklist.Api.Controllers.Categories
{
    public interface ICategoryRepository
    {
        IEnumerable<CategoryModel> GetCategories();
    }

    public class CategoryRepository : ICategoryRepository
    {
        XIVContext _context;
        IMapper _mapper;

        public CategoryRepository(XIVContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<CategoryModel> GetCategories()
        {
            var categories = _context.Category;

            return Map(categories);
        }     
        
        //public IEnumerable<CategoryModel> GetCategoriesForUser(int userId)
        //{
        //    var categories = _context.Category.Where(x => x.AchievementTasks.)
        //}

        //IQueryable<Category> IncludeAll()
        //{
        //    _context.Category.Include(x => x.AchievementTasks)
        //}

        //IEnumerable<ITaskModel> GetTasksForUser(int userId)
        //{
        //    return _context.AchievementTask.
        //}

        IEnumerable<CategoryModel> Map(IEnumerable<Category> categories)
        {
            return categories.Select(x => _mapper.Map<Category, CategoryModel>(x));
        }
    }
}
