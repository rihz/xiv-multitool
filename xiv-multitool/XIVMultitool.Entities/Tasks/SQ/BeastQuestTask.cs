using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Entities.Tasks.SQ
{
    public class BeastQuestTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int BeastTribeId { get; set; }
        public int BeastRankId { get; set; }
        public int Level { get; set; }

        public virtual Category Category { get; set; }
        public virtual BeastTribe BeastTribe { get; set; }
        public virtual BeastRank BeastRank { get; set; }
    }

    public class BeastQuestParse
    {
        public string Tribe { get; set; }
        public string Level { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
    }
}
