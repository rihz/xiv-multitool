using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVChecklist.Api.Controllers.Tasks.Models
{
    public class SQTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int Level { get; set; }
        public int SQTypeId { get; set; }
        public string SQTypeName { get; set; }
    }

    public class RoleQuestTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int JobRoleId { get; set; }
        public string JobRoleName { get; set; }
        public int Level { get; set; }
    }

    public class ClassQuestTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int DisciplineId { get; set; }
        public string DisciplineName { get; set; }
        public int Level { get; set; }
    }

    public class BeastQuestTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int BeastTribeId { get; set; }
        public string BeastTribeName { get; set; }
        public int BeastRankId { get; set; }
        public string BeastRankName { get; set; }
        public int Level { get; set; }
    }
}
