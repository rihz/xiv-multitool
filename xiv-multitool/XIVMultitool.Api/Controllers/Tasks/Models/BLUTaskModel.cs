using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XIVChecklist.Entities.Tasks;

namespace XIVChecklist.Api.Controllers.Tasks.Models
{
    /// <see cref="BLUCarnivaleTask"/>
    public class BLUCarnivaleTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int Stage { get; set; }
        public string StandardTime { get; set; }
        public string IdealTime { get; set; }
    }

    /// <see cref="BLULogTask"/>
    public class BLULogTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int ContentId { get; set; }
        public string ContentName { get; set; }
    }

    /// <see cref="BLUSpellTask"/>
    public class BLUSpellTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int Number { get; set; }
        public IEnumerable<BLUSpellLocationModel> Locations { get; set; }
    }

    public class BLUSpellLocationModel
    {
        public int Id { get; set; }
        public string Mob { get; set; }
        public string Location { get; set; }
    }
}
