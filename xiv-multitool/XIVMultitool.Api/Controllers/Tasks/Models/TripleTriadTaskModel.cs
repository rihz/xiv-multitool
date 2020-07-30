using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVChecklist.Api.Controllers.Tasks.Models
{
    public class OpponentTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public string Zone { get; set; }
        public string Location { get; set; }
    }

    public class CardTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int Rank { get; set; }
        public string NPCName { get; set; }
        public string OtherMethods { get; set; }
    }
}
