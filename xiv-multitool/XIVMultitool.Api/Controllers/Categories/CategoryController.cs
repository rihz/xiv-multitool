using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace XIVChecklist.Api.Controllers.Categories
{
    [Route("api/categories")]
    public class CategoryController : Controller
    {
        ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [Route("")]
        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = _service.GetFullCategories().ToList();
            return Ok(categories);
        }

        //[Route("{userId}")]
        //[HttpGet]
        //public IActionResult GetCategoriesForUser(int userId)
        //{

        //}
    }
}