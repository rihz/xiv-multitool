using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace XIVChecklist.Api.Controllers.Tasks
{
    [Route("api/tasks")]
    public class TaskController : Controller
    {
        ITaskService _service;

        public TaskController(ITaskService service)
        {
            _service = service;
        }

        [Route("")]
        [HttpGet]
        public IActionResult GetTasks()
        {
            return Ok(_service.GetTasks());
        }
    }
}