using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities.Categories;

namespace XIVChecklist.Entities.Tasks.Triple_Triad
{
    public class CardTask : ITask
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public string NPCName { get; set; }
        public string OtherMethods { get; set; }

        public virtual Category Category { get; set; }
    }

    public class CardParse
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public string NPC { get; set; }
        public string OtherMethods { get; set; }
    }
}
