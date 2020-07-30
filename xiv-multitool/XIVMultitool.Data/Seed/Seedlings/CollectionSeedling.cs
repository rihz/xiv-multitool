using System;
using System.Collections.Generic;
using System.Text;

namespace XIVChecklist.Data.Seed.Seedlings
{
    public class CollectionSeedling : Seedling
    {
        public int CollectionTypeId { get; set; }

        public CollectionSeedling(string name, string category)
            : base(name, category)
        {
            CollectionTypeId = SeedCommon.GetCollectionTypeIndex(name);
        }

        public static CollectionSeedling[] Seedlings = new CollectionSeedling[]
        {
            new CollectionSeedling("Aesthetics", "Aesthetics"),
            new CollectionSeedling("Bardings", "Bardings"),
            new CollectionSeedling("Emotes", "Emotes"),
            new CollectionSeedling("Minions", "Minions"),
            new CollectionSeedling("Mounts", "Mounts")
        };
    }
}
