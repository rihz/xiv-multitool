using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVChecklist.Api.Controllers.Tasks.Models
{
    public class MSQTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public string Level { get; set; }
        public int MSQTypeId { get; set; }
        public string MSQTypeName { get; set; }
    }
}
