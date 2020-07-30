using System;
using System.Collections.Generic;
using System.Text;

namespace XIVChecklist.Entities.Tasks
{
    public interface ITask
    {
        int Id { get; set; }
        int CategoryId { get; set; }
        string Name { get; set; }
    }
}
