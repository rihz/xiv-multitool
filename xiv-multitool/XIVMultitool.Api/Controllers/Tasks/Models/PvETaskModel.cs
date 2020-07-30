using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVChecklist.Api.Controllers.Tasks.Models
{
    public class PvETaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int ContentId { get; set; }
        public string ContentName { get; set; }
    }

    public class LeveTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public string Level { get; set; }
        public int LeveTypeId { get; set; }
        public string LeveTypeName { get; set; }
        public string NPCName { get; set; }
    }

    public class FATETaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public string Location { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public int Level { get; set; }
    }
}
