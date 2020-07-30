using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVChecklist.Api.Controllers.Tasks.Models
{
    public class CollectionTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public string Method { get; set; }
        public int CollectionTypeId { get; set; }
        public string CollectionTypeName { get; set; }
    }

    public class OrchestrionTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int Number { get; set; }
        public string Method { get; set; }
        public int OrchestrionTypeId { get; set; }
        public string OrchestrionTypeName { get; set; }
    }

    public class RelicWeaponTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int DisciplineId { get; set; }
        public string DisciplineName { get; set; }
    }
}
