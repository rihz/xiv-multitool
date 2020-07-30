namespace XIVChecklist.Data.Seed.Seedlings
{
    public class AchievementSeedling
    {
        public string FileName { get; set; }
        public int CategoryId { get; set; }
        public int AchievementTypeId { get; set; }

        public AchievementSeedling(string name, string category, string type)
        {
            FileName = name;
            CategoryId = SeedCategories.GetCategoryId(category);
            AchievementTypeId = SeedCommon.GetAchievementTypeId(type);
        }

        public static AchievementSeedling[] Seedlings = new AchievementSeedling[]
        {
            new AchievementSeedling("Abalathia", "Abalathia's Spine", "Exploration"),
            new AchievementSeedling("ALC", "Alchemist", "Crafting"),
            new AchievementSeedling("Anima", "Anima", "Item"),
            new AchievementSeedling("ARM", "Armorer", "Crafting"),
            new AchievementSeedling("Battle", "Battle", "Battle"),
            new AchievementSeedling("Beast Tribe", "Beast Tribe", "Quest"),
            new AchievementSeedling("Black Shroud", "The Black Shroud", "Exploration"),
            new AchievementSeedling("BSM", "Blacksmith", "Crafting"),
            new AchievementSeedling("BTN", "Botanist", "Gathering"),
            new AchievementSeedling("Character", "General", "Character"),
            new AchievementSeedling("Coerthas", "Coerthas", "Exploration"),
            new AchievementSeedling("Collectibles", "Collectibles", "Item"),
            new AchievementSeedling("Commendation", "Commendation", "Character"),
            new AchievementSeedling("CRP", "Carpenter", "Crafting"),
            new AchievementSeedling("CUL", "Culinarian", "Crafting"),
            new AchievementSeedling("Currency", "Currency", "Item"),
            new AchievementSeedling("Deep Dungeon", "Deep Dungeon", "Item"),
            new AchievementSeedling("Desynthesis", "Desynthesis", "Item"),
            new AchievementSeedling("DoH", "Disciples of the Hand", "Character"),
            new AchievementSeedling("DoL", "Disciples of the Land", "Character"),
            new AchievementSeedling("DoM", "Disciples of Magic", "Character"),
            new AchievementSeedling("DoW", "Disciples of War", "Character"),
            new AchievementSeedling("Dravania", "Dravania", "Exploration"),
            new AchievementSeedling("Dungeons", "Dungeons", "Battle"),
            new AchievementSeedling("Duty", "Duty", "Exploration"),
            new AchievementSeedling("Eureka", "Eureka Weapons", "Item"),
            new AchievementSeedling("Frontline", "Frontline", "PvP"),
            new AchievementSeedling("FSH", "Fisher", "Gathering"),
            new AchievementSeedling("GC", "Grand Company", "Grand Company"),
            new AchievementSeedling("Gold Saucer", "Gold Saucer", "Character"),
            new AchievementSeedling("GSM", "Goldsmith", "Crafting"),
            new AchievementSeedling("Gyr Abania", "Gyr Abania", "Exploration"),
            new AchievementSeedling("Immortal Flames", "Immortal Flames", "Grand Company"),
            new AchievementSeedling("Item", "Item", "Item"),
            new AchievementSeedling("La Noscea", "La Noscea", "Exploration"),
            new AchievementSeedling("Levequests", "Levequests", "Quest"),
            new AchievementSeedling("LTW", "Leatherworker", "Crafting"),
            new AchievementSeedling("Maelstrom", "Maelstrom", "Grand Company"),
            new AchievementSeedling("Materia", "Materia", "Item"),
            new AchievementSeedling("MIN", "Miner", "Gathering"),
            new AchievementSeedling("Mor Dhona", "Mor Dhona", "Exploration"),
            new AchievementSeedling("Norvrandt", "Norvrandt", "Exploration"),
            new AchievementSeedling("Othard", "Othard", "Exploration"),
            new AchievementSeedling("PvP", "General", "PvP"),
            new AchievementSeedling("Quest", "Quests", "Quest"),
            new AchievementSeedling("Raids", "Raids", "Battle"),
            new AchievementSeedling("Rankings", "Rankings", "PvP"),
            new AchievementSeedling("Relic", "Relic", "Item"),
            new AchievementSeedling("Rival Wings", "Rival Wings", "PvP"),
            new AchievementSeedling("Sightseeing", "Sightseeing Log", "Exploration"),
            new AchievementSeedling("Thanalan", "Thanalan", "Exploration"),
            new AchievementSeedling("The Hunt", "The Hunt", "Battle"),
            new AchievementSeedling("Treasure Hunt", "Treasure Hunt", "Battle"),
            new AchievementSeedling("Trials", "Trials", "Battle"),
            new AchievementSeedling("Twin Adder", "Order of the Twin Adders", "Grand Company"),
            new AchievementSeedling("Wolves Den", "The Wolves' Den", "PvP"),
            new AchievementSeedling("WVR", "Weaver", "Crafting"),
            new AchievementSeedling("Zodiac", "Zodiac", "Item")
        };
    }
}
