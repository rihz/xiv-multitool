using System.Collections.Generic;
using System.Linq;
using XIVChecklist.Api.Controllers.Tasks;

namespace XIVChecklist.Api.Controllers.Categories
{
    public interface ICategoryService
    {
        IEnumerable<CategoryModel> GetFullCategories();
    }

    public class CategoryService : ICategoryService
    {
        const int MAX_CATEGORY_POSITION = 3;

        ICategoryRepository _repo;
        ITaskService _taskRepo;

        public CategoryService(ICategoryRepository repo, ITaskService taskRepo)
        {
            _repo = repo;
            _taskRepo = taskRepo;
        }

        public IEnumerable<CategoryModel> GetFullCategories()
        {
            var categories = _repo.GetCategories().ToList();
            var tasks = _taskRepo.GetTasks();

            var groupedCategories = categories.GroupBy(x => x.ParentCategoryId,
                (key, elements) => new
                {
                    ParentCategoryId = key,
                    Categories = elements
                }
            );

            var groupedTasks = tasks.GroupBy(x => x.CategoryId,
                (key, elements) => new
                {
                    CategoryId = key,
                    Tasks = elements
                }
            );

            foreach (var group in groupedTasks)
            {
                var c = categories.First(x => x.Id == group.CategoryId);
                    c.Tasks.AddRange(group.Tasks);
            }

            foreach (var group in groupedCategories)
            {
                for (int i = MAX_CATEGORY_POSITION; i > 0; i--)
                {
                    var match = categories.FirstOrDefault(x => x.Id == group.ParentCategoryId && x.Position == i);

                    if(match != default(CategoryModel))
                    {
                        match.Categories.AddRange(group.Categories);
                    }
                }
            }
            
            var final = categories.Where(x => x.ParentCategoryId == 0).ToList();

            return final;
        }
    }
}
