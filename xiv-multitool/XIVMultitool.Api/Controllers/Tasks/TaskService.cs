using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVChecklist.Api.Controllers.Tasks
{
    public interface ITaskService
    {
        IEnumerable<ITaskModel> GetTasks();
    }

    public class TaskService : ITaskService
    {
        ITaskRepository _repo;

        public TaskService(ITaskRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<ITaskModel> GetTasks()
        {
            return _repo.GetTasks();
        }
    }
}
