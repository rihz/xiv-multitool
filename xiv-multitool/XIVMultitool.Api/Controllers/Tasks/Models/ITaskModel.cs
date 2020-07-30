using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVChecklist.Api.Controllers.Tasks
{
    public interface ITaskModel
    {
        int Id { get; set; }
        string Name { get; set; }
        int CategoryId { get; set; }
        int TaskTypeId { get; set; }
    }
}
