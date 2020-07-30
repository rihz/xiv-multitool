using Microsoft.EntityFrameworkCore.Migrations;

namespace XIVChecklist.Data.Migrations
{
    public partial class OrchestrionTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrchestrionTask_Category_CategoryId",
                table: "OrchestrionTask");

            migrationBuilder.DropForeignKey(
                name: "FK_OrchestrionTask_OrchestrionType_OrchestrionTypeId",
                table: "OrchestrionTask");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentCategoryId", "Position" },
                values: new object[] { 78, "Orchestrion", 21, 3 });

            migrationBuilder.InsertData(
                table: "OrchestrionTask",
                columns: new[] { "Id", "CategoryId", "Method", "Name", "Number", "OrchestrionTypeId" },
                values: new object[,]
                {
                    { 1, 78, "Crafted by Level 50 Alchemist (Master Alchemist I ★★) with Faded Copy of A Light in the Storm, dropped in Pharos Sirius or Pharos Sirius (Hard).", "A Light in the Storm", 1, 1 },
                    { 245, 78, "Reward for the quest Of Endings and Beginnings.", "Metal - Brute Justice Mode", 15, 4 },
                    { 244, 78, "Reward for the quest Of Endings and Beginnings.", "Metal", 14, 4 },
                    { 243, 78, "Reward for the quest Of Endings and Beginnings.", "Locus", 13, 4 },
                    { 242, 78, "Reward for the quest Of Endings and Beginnings.", "Sins of the Father, Sins of the Son", 12, 4 },
                    { 241, 78, "Crafted by Level 60 Alchemist (Master Alchemist IV ★★) Faded Copy of Thunderer, Faded Copy of Rise of the White Raven, and Faded Copy of Answers, dropped in The Binding Coil of Bahamut - Turn 5, The Second Coil of Bahamut - Turn 4, and The Final Coil of Bahamut - Turn 4.", "Answers", 11, 4 },
                    { 240, 78, "Crafted by Level 50 Alchemist (Master Alchemist II ★★★★) Faded Copy of From the Ashes, dropped in The Final Coil of Bahamut - Turn 3.", "From the Ashes", 10, 4 },
                    { 239, 78, "Crafted by Level 50 Alchemist (Master Alchemist II ★★★★) Faded Copy of Rise of the White Raven, dropped in The Second Coil of Bahamut - Turn 4.", "Rise of the White Raven", 9, 4 },
                    { 238, 78, "Crafted by Level 50 Alchemist (Master Alchemist II ★★★★) Faded Copy of Thunderer, dropped in The Binding Coil of Bahamut - Turn 5.", "Thunderer", 8, 4 },
                    { 246, 78, "Reward for the quest Thus Spake Quickthinx.", "Exponential Entropy", 16, 4 },
                    { 237, 78, "Crafted by Level 60 Alchemist (Master Alchemist III ★) with Faded Copy of Tumbling Down, Faded Copy of Out of the Labyrinth and Faded Copy of Hunger, dropped in Labyrinth of the Ancients, Syrcus Tower, and World of Darkness.", "Eternal Wind", 7, 4 },
                    { 235, 78, "Crafted by Level 50 Alchemist (Master Alchemist II ★★★★) with Faded Copy of Blind to the Dark, dropped in World of Darkness.", "Blind to the Dark", 5, 4 },
                    { 234, 78, "Crafted by Level 50 Alchemist (Master Alchemist II ★★★★) with Faded Copy of Now I Know the Truth, dropped in Syrcus Tower.", "Now I Know the Truth", 4, 4 },
                    { 233, 78, "Crafted by Level 50 Alchemist (Master Alchemist II ★★★★) with Faded Copy of Out of the Labyrinth, dropped in Syrcus Tower.", "Out of the Labyrinth", 3, 4 },
                    { 232, 78, "Crafted by Level 50 Alchemist (Master Alchemist II ★★★★) with Faded Copy of Tumbling Down, dropped in Labyrinth of the Ancients.", "Tumbling Down", 2, 4 },
                    { 231, 78, "Crafted by Level 50 Alchemist (Master Alchemist II ★★★★) with Faded Copy of Hubris, dropped in Labyrinth of the Ancients.", "Hubris", 1, 4 },
                    { 230, 78, "Bought from Maudlin Latool Ja in Ul'dah for 500 Allied Seals (Requires Level 60 BLU)", "Imperium", 68, 3 },
                    { 229, 78, "Bought from Maudlin Latool Ja in Ul'dah for 500 Allied Seals (Requires Level 60 BLU)", "Nail of the Heavens", 67, 3 },
                    { 228, 78, "Bought from the Wolves' Den Provisioner at Wolves' Den Pier for 10,000 Wolf Marks.", "A Fine Air Forbiddeth", 66, 3 },
                    { 236, 78, "Crafted by Level 50 Alchemist (Master Alchemist II ★★★★) with Faded Copy of Hunger, dropped in World of Darkness.", "Hunger", 6, 4 },
                    { 247, 78, "Reward for the quest Judgment Day.", "Rise", 17, 4 },
                    { 248, 78, "Purchased from Bertana in Idyllshire for 1 Alexandrian Gear.", "Moebius", 18, 4 },
                    { 249, 78, "Bought from the Gold Saucer Attendant <Prize Claim> at the Gold Saucer for 30,000 MGP.", "Tempest", 19, 4 },
                    { 268, 78, "Unlocking Alphascape 1.0", "Deltascape", 38, 4 },
                    { 267, 78, "Acquired in The Ridorana Lighthouse", "Flash of Steel", 37, 4 },
                    { 266, 78, "Acquired in The Ridorana Lighthouse", "Apoplexy", 36, 4 },
                    { 265, 78, "Acquired in The Ridorana Lighthouse", "The Mystery of Giruvegan", 35, 4 },
                    { 264, 78, "Reward for Annihilation", "A Chapel", 34, 4 },
                    { 263, 78, "Reward for the quest Desire", "World Map", 33, 4 },
                    { 262, 78, "Drops from Syrcus Tower.", "Shattered", 32, 4 },
                    { 261, 78, "Reward for the quest A City Fallen.", "Background Story", 31, 4 },
                    { 260, 78, "Reward for the quest A City Fallen.", "Protagonist's Theme", 30, 4 },
                    { 259, 78, "Drops from the final chest of The Royal City of Rabanastre.", "Ultima's Transformation", 29, 4 },
                    { 258, 78, "Drops from the final chest of The Royal City of Rabanastre.", "Precipitous Combat", 28, 4 },
                    { 257, 78, "Drops from the final chest of The Royal City of Rabanastre.", "Trisection", 27, 4 },
                    { 256, 78, "Reward for the quest Where Shadows Reign.", "Shadow of the Body", 26, 4 },
                    { 255, 78, "Reward for the quest Where Shadows Reign.", "Promises", 25, 4 },
                    { 254, 78, "Purchased from Bertana in Idyllshire for 1 Mhachi Penny.", "A Thousand Faces", 24, 4 },
                    { 253, 78, "Purchased from Bertana in Idyllshire for 1 Mhachi Penny.", "Teardrops in the Rain", 23, 4 },
                    { 252, 78, "Purchased from Bertana in Idyllshire for 1 Mhachi Farthing.", "Six Fulms Under", 22, 4 },
                    { 251, 78, "Purchased from Bertana in Idyllshire for 1 Mhachi Farthing.", "Aetherosphere", 21, 4 },
                    { 250, 78, "Bought from the Gold Saucer Attendant <Prize Claim> at the Gold Saucer for 30,000 MGP.", "Spiral", 20, 4 },
                    { 227, 78, "Bought from the Wolves' Den Provisioner at Wolves' Den Pier for 10,000 Wolf Marks.", "A Fierce Air Forceth", 65, 3 },
                    { 269, 78, "Deltascape V1.0, V2.0, or V3.0.", "Omega Squared", 39, 4 },
                    { 226, 78, "Drops from Dungeons of Lyhe Ghiah", "Insatiable", 64, 3 },
                    { 224, 78, "Level 80 Main Quest Shadowbringers", "Tomorrow and Tomorrow", 62, 3 },
                    { 200, 78, "Reward for the quest Rise of a New Sun.", "Cyan's Theme", 38, 3 },
                    { 199, 78, "Bought from Housing Merchant in Residential Districts for 5,000 Gil.", "Chapel Bell", 37, 3 },
                    { 198, 78, "Bought from Housing Merchant in Residential Districts for 5,000 Gil.", "Temple Bell", 36, 3 },
                    { 197, 78, "Bought from Housing Merchant in Residential Districts for 5,000 Gil.", "Bustling Boulevard", 35, 3 },
                    { 196, 78, "Bought from Housing Merchant in Residential Districts for 5,000 Gil.", "Babbling Brook", 34, 3 },
                    { 195, 78, "Bought from the Materia Provisioner at the Wolves' Den Pier for 10,000 Wolf Marks.", "Rival Wings", 33, 3 },
                    { 194, 78, "Bought from the Materia Provisioner at the Wolves' Den Pier for 10,000 Wolf Marks.", "Birds of Prey", 32, 3 },
                    { 193, 78, "Bought from Housing Merchant in Residential Districts for 5,000 Gil.", "Ambient Kitchen", 31, 3 },
                    { 201, 78, "Reward for the quest An Auspicious Encounter.", "Iroha", 39, 3 },
                    { 192, 78, "Bought from Housing Merchant in Residential Districts for 5,000 Gil.", "Ambient Bonfire", 30, 3 },
                    { 190, 78, "Bought from Housing Merchant in Residential Districts for 5,000 Gil.", "Ambient Cricketsong", 28, 3 },
                    { 189, 78, "Bought from Housing Merchant in Residential Districts for 5,000 Gil.", "Ambient Rainfall", 27, 3 },
                    { 188, 78, "Bought from Housing Merchant in Residential Districts for 5,000 Gil.", "Ambient Birdsong", 26, 3 },
                    { 187, 78, "Bought from Housing Merchant in Residential Districts for 5,000 Gil.", "Ambient Waves", 25, 3 },
                    { 186, 78, "Reward for the quest The Obvious Solution.", "Steel Reason", 24, 3 },
                    { 185, 78, "Reward for the quest Fly Free, My Pretty.", "Imperial Will", 23, 3 },
                    { 184, 78, "Reward for the quest Fly Free, My Pretty.", "He Who Continues the Attack", 22, 3 },
                    { 183, 78, "Chance of dropping when opening lockboxes obtained from coffers and FATEs in The Diadem.", "Jewel", 21, 3 },
                    { 191, 78, "Bought from Housing Merchant in Residential Districts for 5,000 Gil.", "Ambient Insects", 29, 3 },
                    { 202, 78, "Bought from Kasumi at the Gold Saucer for 5,000 Gil.", "Darling Dalliances", 40, 3 },
                    { 203, 78, "Bought from Housing Merchant in Residential Districts for 5,000 Gil.", "Fragments of Forever", 41, 3 },
                    { 204, 78, "Bought from the Gold Saucer Attendant <Prize Claim> at the Gold Saucer for 50,000 MGP.", "Revenge Twofold", 42, 3 },
                    { 223, 78, "Level 70 Main Quest The Syrcus Trench", "Shadowbringers", 61, 3 },
                    { 222, 78, "Acquired from The Baldesion Arsenal", "Turmoil", 60, 3 },
                    { 221, 78, "Acquired from The Forbidden Land, Eureka Hydatos", "Onslaught", 59, 3 },
                    { 220, 78, "Acquired from The Forbidden Land, Eureka Hydatos", "Gates of Paradise", 58, 3 },
                    { 219, 78, "Complete Achievement \"Tile and Error I\"", "Doman Distractions", 57, 3 },
                    { 218, 78, "MGP Exchange at the Golden Saucer", "Game Theory", 56, 3 },
                    { 217, 78, "MGP Exchange at the Golden Saucer", "Rise of Heroes (Chiptune Version)", 55, 3 },
                    { 216, 78, "Post Alphascape 4.0 Quest", "A Dream in Flight", 54, 3 },
                    { 215, 78, "Post Alphascape 4.0 Quest", "Ending", 53, 3 },
                    { 214, 78, "Exchange in Kugane", "Cornerstone of the New World - Astera", 52, 3 },
                    { 213, 78, "Obtained from a piece of the Accursed Horn in Heaven-on-High", "Parting Ways", 51, 3 },
                    { 212, 78, "Exchange in Crick", "Far East of Eorzea", 50, 3 },
                    { 211, 78, "Purchased from Junkmonger", "Victory or Death", 49, 3 },
                    { 210, 78, "Acquired from The Mystic Basin", "Ambient Abyss", 48, 3 },
                    { 209, 78, "Purchased from Housing/Apartment merchant", "Ambient Wind Chime", 47, 3 },
                    { 208, 78, "Chance of dropping when opening Anemos lockboxes obtained from FATEs in Eureka Anemos.", "No Quarter", 46, 3 },
                    { 207, 78, "Chance of dropping when opening Anemos lockboxes obtained from FATEs in Eureka Anemos.", "Wicked Winds Whisper", 45, 3 },
                    { 206, 78, "Add 200 unique music rolls to your orchestrion.", "Prelude - Long March Home", 44, 3 },
                    { 205, 78, "Bought from the Gold Saucer Attendant <Prize Claim> at the Gold Saucer for 50,000 MGP.", "Triumph", 43, 3 },
                    { 225, 78, "Exchange in Crystarium or Eulmore", "Rencounter", 63, 3 },
                    { 182, 78, "Reward for the quest Louisoix's Finest Student.", "Forever Lost", 20, 3 },
                    { 270, 78, "Deltascape V4.0.", "Decisions", 40, 4 },
                    { 272, 78, "Sigmascape V1.0, V2.0, or V3.0.", "A Battle Decisively", 42, 4 },
                    { 335, 78, "Bought from the Gold Saucer Attendant <Prize Claim> at the Gold Saucer for 20,000 MGP.", "Battle to the Death - Heavensward", 14, 6 },
                    { 334, 78, "Crafted by Level 50 Alchemist (Master Alchemist I ★★) with Faded Copy of Battle on the Big Bridge, dropped in Battle on the Big Bridge or Battle in the Big Keep.", "Battle on the Big Bridge", 13, 6 },
                    { 333, 78, "Crafted by Level 60 Alchemist (Master Alchemist IV ★★) with Faded Copy of Revenge of the Horde, dropped in The Minstrel's Ballad: Nidhogg's Rage.", "Revenge of the Horde", 12, 6 },
                    { 332, 78, "Crafted by Level 50 Alchemist (Master Alchemist I ★★★) with Faded Copy of Good King Moggle Mog XII, dropped in Thornmarch (Extreme).", "Good King Moggle Mog XII", 11, 6 },
                    { 331, 78, "Crafted by Level 50 Alchemist (Master Alchemist I ★★★) with Faded Copy of Through the Maelstrom, dropped in The Whorleater (Extreme).", "Through the Maelstrom", 10, 6 },
                    { 330, 78, "Crafted by Level 50 Alchemist (Master Alchemist I ★★★) from Faded Copy of Wreck to the Seaman, dropped in The Whorleater (Extreme).", "Wreck to the Seaman", 9, 6 },
                    { 329, 78, "Crafted by Level 60 Alchemist (Master Alchemist III ★) from Faded Copy of Fiend, dropped in Containment Bay S1T7 (Extreme).", "Fiend", 8, 6 },
                    { 328, 78, "Crafted by Level 60 Alchemist (Master Alchemist III ★) from Faded Copy of Heroes, dropped in The Minstrel's Ballad: Thordan's Reign.", "Heroes", 7, 6 },
                    { 336, 78, "Crafted by Level 50 Alchemist (Master Alchemist II ★★★★) with Faded Copy of Footsteps in the Snow, dropped in Akh Afah Amphitheatre (Extreme).", "Footsteps in the Snow", 15, 6 },
                    { 327, 78, "Crafted by Level 50 Alchemist (Master Alchemist I ★★★) from Faded Copy of Under the Weight, dropped in The Navel (Extreme).", "Under the Weight", 6, 6 },
                    { 325, 78, "Crafted by Level 50 Alchemist (Master Alchemist I ★★★) from Faded Copy of Primal Judgment, dropped in The Bowl of Embers (Extreme).", "Primal Judgment", 4, 6 },
                    { 324, 78, "Crafted by Level 50 Alchemist (Master Alchemist I ★★★) from Faded Copy of The Maker's Ruin, dropped in The Minstrel's Ballad: Ultima's Bane.", "The Maker's Ruin", 3, 6 },
                    { 323, 78, "Add 30 unique music rolls to your orchestrion.", "Ultima", 2, 6 },
                    { 322, 78, "Bought from the Gold Saucer Attendant <Prize Claim> at the Gold Saucer for 30,000 MGP.", "Torn from the Heavens", 1, 6 },
                    { 321, 78, "Starlight Celebration (2019) Seasonal Event", "Starlight De Chocobo", 22, 5 },
                    { 320, 78, "Trade Unidentified Magitek with Ironworks Hand", "A Quick Pit Stop", 21, 5 },
                    { 319, 78, "Trade Unidentified Magitek with Ironworks Hand", "Apocalypsis Noctis", 20, 5 },
                    { 318, 78, "Trade Unidentified Magitek with Ironworks Hand", "Veiled in Black", 19, 5 },
                    { 326, 78, "Crafted by Level 50 Alchemist (Master Alchemist I ★★★) from Faded Copy of Fallen Angel, dropped in The Howling Eye (Extreme).", "Fallen Angel", 5, 6 },
                    { 337, 78, "Crafted by Level 50 Alchemist (Master Alchemist II ★★★★) with Faded Copy of Oblivion, dropped in Akh Afah Amphitheatre (Extreme).", "Oblivion", 16, 6 },
                    { 338, 78, "Crafted by Level 50 Alchemist (Master Alchemist II ★★★★) with Faded Copy of Thunder Rolls, dropped in The Striking Tree (Extreme).", "Thunder Rolls", 17, 6 },
                    { 339, 78, "Crafted by Level 60 Alchemist (Master Alchemist IV ★★) with Faded Copy of Equilibrium, dropped in Containment Bay P1T6 (Extreme).", "Equilibrium", 18, 6 },
                    { 358, 78, "Level 80★ Alchemist (Master Alchemist VI) from Faded Copy of From the Dancing Plague (Extreme)", "What Angel Wakes Me", 37, 6 },
                    { 357, 78, "Level 70★★★ Alchemist (Master Alchemist VI) from Faded Copy of From the Dragon's Wake", "From the Dragon's Wake", 36, 6 },
                    { 356, 78, "Level 70★★★ Alchemist (Master Alchemist VI) from Faded Copy of Sunrise", "Sunrise", 35, 6 },
                    { 355, 78, "Obtained in the Great Hunt (Extreme)", "Proof of a Hero - Monster Hunter World Version", 34, 6 },
                    { 354, 78, "Available for Exchange in Kugane", "Savage of the Ancient Forest", 33, 6 },
                    { 353, 78, "Level 70★★★ Alchemist (Master Alchemist VI) from Faded Copy of Under the Moonlight", "Wayward Daughter", 32, 6 },
                    { 352, 78, "Level 70★★★ Alchemist (Master Alchemist VI) from Faded Copy of Under the Moonlight", "Nightbloom", 31, 6 },
                    { 351, 78, "Crafted by Level 70 Alchemist (Master Alchemist VI ★★★) from Faded Copy of the Jade Stoa, dropped in The Jade Stoa (Extreme).", "Amatsu Kaze", 30, 6 },
                    { 350, 78, "Crafted by Level 70 Alchemist (Master Alchemist VI ★★★) from Faded Copy of the Jade Stoa, dropped in The Jade Stoa (Extreme).", "Answer on High", 29, 6 },
                    { 349, 78, "Crafted by Level 70 Alchemist (Master Alchemist V ★) from Faded Copy of The Worm's Tail, dropped in Minstrel's Ballad: Shinryu's Domain.", "The Worm's Tail", 28, 6 },
                    { 348, 78, "Crafted by Level 70 Alchemist (Master Alchemist V ★) from Faded Copy of The Worm's Tail, dropped in Minstrel's Ballad: Shinryu's Domain.", "The Worm's Head", 27, 6 },
                    { 347, 78, "Crafted by Level 70 Alchemist (Master Alchemist IV ★) with Faded Copy of Beauty's Wicked Wiles, dropped in Emanation (Extreme).", "Beauty's Wicked Wiles", 26, 6 },
                    { 346, 78, "Crafted by Level 70 Alchemist (Master Alchemist IV ★) with Faded Copy of Revelation, dropped in The Pool of Tribute (Extreme).", "Revelation", 25, 6 },
                    { 345, 78, "Crafted by Level 60 Alchemist (Master Alchemist IV ★★★) with Faded Copy of Infinity, dropped in Containment Bay Z1T9 (Extreme).", "Infinity", 24, 6 },
                    { 344, 78, "Crafted by Level 60 Alchemist (Master Alchemist III ★) with Faded Copy of Unbending Steel, dropped in Thok ast Thok (Extreme).", "Unbending Steel", 23, 6 },
                    { 343, 78, "Crafted by Level 60 Alchemist (Master Alchemist III ★) with Faded Copy of The Hand That Gives the Rose, dropped in Thok ast Thok (Extreme).", "The Hand That Gives the Rose", 22, 6 },
                    { 342, 78, "Crafted by Level 60 Alchemist (Master Alchemist III ★) with Faded Copy of Woe That Is Madness, dropped in The Limitless Blue (Extreme).", "Woe That Is Madness", 21, 6 },
                    { 341, 78, "Crafted by Level 60 Alchemist (Master Alchemist III ★) with Faded Copy of Limitless Blue, dropped in The Limitless Blue (Extreme).", "Limitless Blue", 20, 6 },
                    { 340, 78, "Crafted by Level 50 Alchemist (Master Alchemist II ★★★★) with Faded Copy of The Corpse Hall, dropped in Urth's Fount.", "The Corpse Hall", 19, 6 },
                    { 317, 78, "Trade Unidentified Magitek with Ironworks Hand", "Relax and Reflect", 18, 5 },
                    { 271, 78, "2 Deltascape Bolts", "Final, Not Final", 41, 4 },
                    { 316, 78, "Trade Unidentified Magitek with Ironworks Hand", "Valse di Fantastica", 17, 5 },
                    { 314, 78, "Starlight Celebration (2018) Seasonal Event", "Starlight, Starbright", 15, 5 },
                    { 290, 78, "Obtained in Eden's Gate: Resurrection or Descent.", "Force Your Way", 60, 4 },
                    { 289, 78, "Orbonne Monastery", "Ultima's Perfection", 59, 4 },
                    { 288, 78, "Orbonne Monastery", "A Man Consumed", 58, 4 },
                    { 287, 78, "Orbonne Monastery", "Antipyretic", 57, 4 },
                    { 286, 78, "Orbonne Monastery", "Fear (No. 1)", 56, 4 },
                    { 285, 78, "Orbonne Monastery", "Under the Stars", 55, 4 },
                    { 284, 78, "Return to Ivalice Quests", "Alma's Theme", 54, 4 },
                    { 283, 78, "Return to Ivalice Quests", "Staff Credits", 53, 4 },
                    { 291, 78, "Obtained in Eden's Gate: Inundation.", "Blinding Indigo", 61, 4 },
                    { 282, 78, "Exchange in Old Gridania", "Beyond Redemption", 52, 4 },
                    { 280, 78, "Alphascape V4.0.", "Heartless", 50, 4 },
                    { 279, 78, "Alphascape V3.0.", "eScape", 49, 4 },
                    { 278, 78, "Alphascape V2.0.", "Primogenitor", 48, 4 },
                    { 277, 78, "Alphascape V1.0.", "Battle", 47, 4 },
                    { 276, 78, "2 Sigmascape Bolts", "Dancing Mad - Movement IV", 46, 4 },
                    { 275, 78, "Sigmascape V4.0.", "Dancing Mad - Movement III", 45, 4 },
                    { 274, 78, "Sigmascape V4.0.", "Dancing Mad - Movement II", 44, 4 },
                    { 273, 78, "Sigmascape V4.0.", "Dancing Mad - Movement I", 43, 4 },
                    { 281, 78, "2 Alphascape Bolts", "From the Heavens", 51, 4 },
                    { 292, 78, "Obtained in Eden's Gate: Sepulture.", "Landslide", 62, 4 },
                    { 293, 78, "YoRHa: Dark Apocalypse Quests", "Significance", 63, 4 },
                    { 294, 78, "The Copied Factory", "City Ruins (Rays of Light)", 64, 4 },
                    { 313, 78, "The Rising (2018) Seasonal Event", "Revolutions", 14, 5 },
                    { 312, 78, "Little Ladies' Day (2018) Seasonal Event", "Siren Song", 13, 5 },
                    { 311, 78, "Starlight Celebration (2017) Seasonal Event. 3 USD / 2.1 EUR", "Starlit Gateway", 12, 5 },
                    { 310, 78, "The Rising (2017) Seasonal Event. 3 USD / 2.1 EUR", "Stormblood", 11, 5 },
                    { 309, 78, "The Rising (2017) Seasonal Event. 3 USD / 2.1 EUR", "Answers - Reprise", 10, 5 },
                    { 308, 78, "Moonfire Faire (2017) Seasonal Event. 3 USD / 2.1 EUR", "Hyper Rainbow Z", 9, 5 },
                    { 307, 78, "Valentione's Day (2017) Seasonal Event. MogStation: 3 USD / 2.1 EUR", "The Kiss", 8, 5 },
                    { 306, 78, "Heavensturn (2017) Seasonal Event. MogStation: 3 USD / 2.1 EUR", "Heavensturn", 7, 5 },
                    { 305, 78, "Starlight Celebration Seasonal Event. 3 USD / 2.1 EUR", "Starlight Celebration", 6, 5 },
                    { 304, 78, "All Saints' Wake (2016) Seasonal Event. 3 USD / 2.1 EUR", "Up at Dawn", 5, 5 },
                    { 303, 78, "All Saints' Wake (2016) Seasonal Event. 3 USD / 2.1 EUR", "All Saints' Wake", 4, 5 },
                    { 302, 78, "The Rising (2016) Seasonal Event. 3 USD / 2.1 EUR", "Heavensward", 3, 5 },
                    { 301, 78, "Moonfire Faire (2016) Seasonal Event. 3 USD / 2.1 EUR", "Moonfire Faire", 2, 5 },
                    { 300, 78, "Hatching-tide (2016) Seasonal Event. MogStation: 3 USD / 2.1 EUR", "Pa-Paya", 1, 5 },
                    { 299, 78, "The Copied Factory", "Weight of the World (Prelude Version)", 69, 4 },
                    { 298, 78, "The Copied Factory", "The Sound of the End", 68, 4 },
                    { 297, 78, "The Copied Factory", "Song of the Ancients (Atonement)", 67, 4 },
                    { 296, 78, "The Copied Factory", "Alien Manifestation", 66, 4 },
                    { 295, 78, "YoRHa: Dark Apocalypse Quests", "Voice of no Return", 65, 4 },
                    { 315, 78, "Trade Unidentified Magitek with Ironworks Hand", "Hammerhead", 16, 5 },
                    { 181, 78, "Bought from Housing Merchant in Residential Districts for 5,000 Gil.", "Canticle", 19, 3 },
                    { 180, 78, "Teleportation ward for The Aquapolis randomly spawns after the completion of a Timeworn Dragonskin Map.", "Breaking Boundaries", 18, 3 },
                    { 179, 78, "Bought from the Gold Saucer Attendant <Prize Claim> at the Gold Saucer for 20,000 MGP.", "Battle Theme 1.x", 17, 3 },
                    { 64, 78, "Purchased from Maisenta in New Gridania for 5,000 Gil.", "Dance of the Fireflies", 12, 7 },
                    { 63, 78, "Purchased from Bango Zango in Limsa Lominsa Lower Decks for 5,000 Gil.", "A Sailor Never Sleeps", 11, 7 },
                    { 62, 78, "Purchased from Gold Saucer Attendant <Prize Claim> for 15,000 MGP.", "Sport of Kings", 10, 7 },
                    { 61, 78, "Purchased from Gold Saucer Attendant <Prize Claim> for 10,000 MGP.", "Four-sided Circle", 9, 7 },
                    { 60, 78, "Crafted by Level 50 Alchemist with Faded Copy of Another Round, purchased from Auriana in Mor Dhona for 1,000 Allagan Tomestones of Poetics.", "Another Round", 8, 7 },
                    { 59, 78, "Crafted by Level 60 Alchemist (Master Alchemist III) with Faded Copy of Lost in the Clouds, dropped by the elite marks Bird of Paradise, Enkelados, and Sisiutl upon death.", "Lost in the Clouds", 7, 7 },
                    { 58, 78, "Crafted by Level 60 Alchemist (Master Alchemist III) with Faded Copy of Painted Foothills, dropped by the elite marks Lord of the Wyverns, Pylraster, and Senmurv upon death.", "Painted Foothills", 6, 7 },
                    { 57, 78, "Purchased from Haneko Burneko in The Waking Sands for 5,000 Gil.", "The Waking Sands", 5, 7 },
                    { 65, 78, "Purchased from Roarich in Ul'dah - Steps of Nald for 5,000 Gil.", "Sultana Dreaming", 13, 7 },
                    { 56, 78, "Purchased from Frine in The Pillars for 5,000 Gil.", "Solid", 4, 7 },
                    { 54, 78, "Purchased from Bango Zango in Limsa Lominsa Lower Decks for 5,000 Gil.", "I Am the Sea", 2, 7 },
                    { 53, 78, "Purchased from Maisenta in New Gridania for 5,000 Gil.", "Wailers and Waterwheels", 1, 7 },
                    { 52, 78, "Drops in The Grand Cosmos", "The Grand Cosmos", 52, 1 },
                    { 51, 78, "Drops in The Twinning", "A Long Fall", 51, 1 },
                    { 50, 78, "Drops in Akadaemia Anyder", "Shadows Withal", 50, 1 },
                    { 49, 78, "Drops in Amaurot", "Mortal Instants", 49, 1 },
                    { 48, 78, "Drops in Mt. Gulg", "In the Belly of the Beast", 48, 1 },
                    { 47, 78, "Drops in Malikah's Well", "Deep Down", 47, 1 },
                    { 55, 78, "Purchased from Roarich in Ul'dah - Steps of Nald for 5,000 Gil.", "A New Hope", 3, 7 },
                    { 66, 78, "Purchased from Frine in The Pillars for 5,000 Gil.", "Nobility Obliges", 14, 7 },
                    { 67, 78, "Purchased from the Junkmonger in Matoya's Cave for 5,000 Gil.", "The Mushroomery", 15, 7 },
                    { 68, 78, "Purchased from the Traveling Merchant in Tailfeather for 5,000 Gil.", "Shelter", 16, 7 },
                    { 87, 78, "Purchased from the Junkmonger in Idyllshire for 5,000 Gil.", "Homestead", 35, 7 },
                    { 86, 78, "Purchase from Housing Merchants.", "Where the Heart Is", 34, 7 },
                    { 85, 78, "Purchase from Auriana in Mor Dhona for 1000 Allagan Tomestones of Poetics.", "Reflections", 33, 7 },
                    { 84, 78, "Purchased from Maisenta in New Gridania, Roarich in Ul'dah Steps of Nald, or Bango Zango in Limsa Lominsa Lower Decks for 5,000 Gil.", "Behind Closed Doors", 32, 7 },
                    { 83, 78, "Purchased from Luna Vanu in the Sea of Clouds for 3 Vanu Whitebone.", "Coming Home", 31, 7 },
                    { 82, 78, "Purchased from the Amalj'aa Vendor in Southern Thanalan for 3 Steel Amalj'ok.", "Smoulder", 30, 7 },
                    { 81, 78, "Crafted by Level 60 Alchemist (Master Alchemist III) with Faded Copy of Lost in the Clouds, dropped by the elite marks Bird of Paradise, Enkelados, and Sisiutl upon death.", "Close to the Heavens", 29, 7 },
                    { 80, 78, "Purchased from Frine in The Pillars for 5,000 Gil.", "Night in the Brume", 28, 7 },
                    { 79, 78, "Purchased from Frine in The Pillars for 5,000 Gil.", "Nobility Sleeps", 27, 7 },
                    { 78, 78, "Teleportation ward for The Aquapolis randomly spawns after the completion of a Timeworn Dragonskin Map.", "Unspoken", 26, 7 },
                    { 77, 78, "Teleportation ward for The Aquapolis randomly spawns after the completion of a Timeworn Dragonskin Map.", "Twilight over Thanalan", 25, 7 },
                    { 76, 78, "Teleportation ward for The Aquapolis randomly spawns after the completion of a Timeworn Dragonskin Map.", "Whisper of the Land", 24, 7 },
                    { 75, 78, "Teleportation ward for The Aquapolis randomly spawns after the completion of a Timeworn Dragonskin Map.", "On Windy Meadows", 23, 7 },
                    { 74, 78, "Purchased from Roarich in Ul'dah Steps of Nald for 5,000 Gil.", "To the Sun", 22, 7 },
                    { 73, 78, "Purchased from Maisenta in New Gridania for 5,000 Gil.", "Serenity", 21, 7 },
                    { 72, 78, "Purchased from Bango Zango in Limsa Lominsa Lower Decks for 5,000 Gil.", "On Westerly Winds", 20, 7 },
                    { 71, 78, "Crafted by Level 60 Alchemist (Master Alchemist III) with Faded Copy of Missing Pages, dropped from the elite marks Slipkinx Steeljoints, Stolas, and The Pale Rider upon death.", "Missing Pages", 19, 7 },
                    { 70, 78, "Crafted by Level 60 Alchemist (Master Alchemist III) with Faded Copy of Landlords, dropped from the elite marks Agathos, Bune, and Gandarewa upon death.", "Landlords", 18, 7 },
                    { 69, 78, "Crafted by Level 60 Alchemist (Master Alchemist III) with Faded Copy of Against the Wind, dropped from the elite marks Kaiser Behemoth, Lyuba, and Mirka upon death.", "Against the Wind", 17, 7 },
                    { 46, 78, "Drops in The Qitana Ravel", "Unwound", 46, 1 },
                    { 88, 78, "Purchased from the Sylphic Vendor at Little Solace in East Shroud for 3 Sylphic Goldleaves.", "Flibbertigibbet", 36, 7 },
                    { 45, 78, "Drops in Dohn Mheg", "Figments", 45, 1 },
                    { 43, 78, "Drops in Castrum Abania", "Alienus", 43, 1 },
                    { 19, 78, "Purchased from E-Una-Kotor in Quarrymill for 10 Gelmorran Potsherd after completing 200th Floor of Palace of the Dead.", "Notice of Death", 19, 1 },
                    { 18, 78, "Purchased from E-Una-Kotor in Quarrymill for 5 Gelmorran Potsherd after completing 150th Floor of Palace of the Dead.", "Fog of Phantom", 18, 1 },
                    { 17, 78, "Purchased from E-Una-Kotor in Quarrymill for 1 Gelmorran Potsherd after completing 100th Floor of Palace of the Dead.", "Blasphemous Experiment", 17, 1 },
                    { 16, 78, "Chance of dropping when opening Iron-trimmed Sacks obtained from the Accursed Hoard between Floors 51-100 of Palace of the Dead.", "Blackbosom", 16, 1 },
                    { 15, 78, "Reward for the quest Shadows of the First.", "Grounded", 15, 1 },
                    { 14, 78, "Drops from Sohm Al.", "Slumber Eternal", 14, 1 },
                    { 13, 78, "Drops from The Keeper of the Lake.", "Silver Tears", 13, 1 },
                    { 12, 78, "Drops from Sohr Khai.", "Apologies", 12, 1 },
                    { 20, 78, "Drops from The Vault.", "Hallowed Halls", 20, 1 },
                    { 11, 78, "Drops from The Fractal Continuum.", "Unbreakable", 11, 1 },
                    { 9, 78, "Drops from Snowcloak.", "The Warrens", 9, 1 },
                    { 8, 78, "Drops from Hullbreaker Isle or Hullbreaker Isle (Hard).", "Horizons Calling", 8, 1 },
                    { 7, 78, "Crafted by Level 60 Alchemist (Master Alchemist III ★) with Faded Copy of Down the Up Staircase, dropped in The Antitower.", "Down the Up Staircase", 7, 1 },
                    { 6, 78, "Crafted by Level 60 Alchemist (Master Alchemist III) with Faded Copy of Imagination, dropped in The Aetherochemical Research Facility.", "Imagination", 6, 1 },
                    { 5, 78, "Crafted by Level 30 Alchemist with Faded Copy of Riptide, dropped in Sastasha or Sastasha (Hard).", "Riptide", 5, 1 },
                    { 4, 78, "Crafted by Level 30 Alchemist with Faded Copy of Dark Vows, dropped in Tam-Tara Deepcroft or Tam-Tara Deepcroft (Hard).", "Dark Vows", 4, 1 },
                    { 3, 78, "Crafted by Level 50 Alchemist (Master Alchemist I ★★) with Faded Copy of The Scars of Battle, dropped in The Lost City of Amdapor or The Lost City of Amdapor (Hard).", "The Scars of Battle", 3, 1 },
                    { 2, 78, "Crafted by Level 30 Alchemist with Faded Copy of The Dark's Embrace, dropped in Copperbell Mines or Copperbell Mines (Hard).", "The Dark's Embrace", 2, 1 },
                    { 10, 78, "Drops from The Great Gubal Library.", "Ink Long Dry", 10, 1 },
                    { 21, 78, "Reward for the quest The Fires of Sohm Al.", "Quicksand", 21, 1 },
                    { 22, 78, "Reward for the quest Griffin, Griffin on the Wall.", "Another Brick", 22, 1 },
                    { 23, 78, "Drops from Saint Mocianne's Arboretum.", "Poison Ivy", 23, 1 },
                    { 42, 78, "Drops in Brayflox's Longstop", "Fury", 42, 1 },
                    { 41, 78, "Drops in the Ghimlyt Dark", "A Pall Most Murderous", 41, 1 },
                    { 40, 78, "Drops from The Burn.", "A Land Long Dead", 40, 1 },
                    { 39, 78, "Drops from Saint Mocianne's Arboretum (Hard).", "From Mud", 39, 1 },
                    { 38, 78, "Drops from Halatali (Hard)", "Beneath Bloodied Banners", 38, 1 },
                    { 37, 78, "Drops from Wanderer's Palace (Hard)", "Tricksome", 37, 1 },
                    { 36, 78, "Drops from Pharos Sirius (Hard)", "Upon the Rocks", 36, 1 },
                    { 35, 78, "Drops in the Swallow's Compass", "Earth, Wind, and Water", 35, 1 },
                    { 34, 78, "Drops from Doma Castle", "Gates of the Moon", 34, 1 },
                    { 33, 78, "Drops from The Lost City of Amdapor (Hard)", "The Ancient City", 33, 1 },
                    { 32, 78, "Drops from The Fractal Continuum (Hard).", "Unbreakable (Duality)", 32, 1 },
                    { 31, 78, "Drops from Hells' Lid.", "Down Where Daemons Dwell", 31, 1 },
                    { 30, 78, "Drops from Ala Mhigo.", "Liberty or Death", 30, 1 },
                    { 29, 78, "Drops from The Temple of the Fist.", "Their Deadly Mission", 29, 1 },
                    { 28, 78, "Drops from Drowned City of Skalla.", "Far From Home", 28, 1 },
                    { 27, 78, "Drops from Kugane Castle.", "Deception", 27, 1 },
                    { 26, 78, "Drops from Bardam's Mettle.", "Most Unworthy", 26, 1 },
                    { 25, 78, "Drops from Shisui of the Violet Tides.", "The Open Box", 25, 1 },
                    { 24, 78, "Drops from The Great Gubal Library (Hard).", "Bibliophobia", 24, 1 },
                    { 44, 78, "Drops in Holminster Switch", "To Fire and Sword", 44, 1 },
                    { 89, 78, "Purchased from the Vath Stickpeddler in The Dravanian Forelands for 3 Black Copper Gil.", "Piece of Mind", 37, 7 },
                    { 90, 78, "Purchased from Auriana in Mor Dhona for 1,000 Allagan Tomestones of Poetics.", "Frontiers Within", 38, 7 },
                    { 91, 78, "Purchased from Chachamun in Eastern Thanalan for 5,000 Gil after the successful completion of the third FATE in the Attack on Highbridge FATE series, Attack on Highbridge: Act II.", "Fleeting Rays", 39, 7 },
                    { 155, 78, "Buying the \"Primals Zepp Tour 2018\" Blu-Ray", "Oblivion (GUNN Vocals)", 13, 2 },
                    { 154, 78, "Buying the \"Journeys: FINAL FANTASY XIV Arrangement\" Album", "The Worm's Tale (Journeys Version)", 12, 2 },
                    { 153, 78, "Buying the \"Journeys: FINAL FANTASY XIV Arrangement\" Album", "eScape (Journeys Version) Orchestrion Roll", 11, 2 },
                    { 152, 78, "Buying the \"Eorzean Symphony\" Album", "Ultima (Orchestral)", 10, 2 },
                    { 151, 78, "Buying the \"Eorzean Symphony\" Album", "Heroes (Orchestral)", 9, 2 },
                    { 150, 78, "Buying the \"Duality\" Arrangement Album", "Borderless (Duality)", 8, 2 },
                    { 149, 78, "Buying the \"Duality\" Arrangement Album", "Unbending Steel (Duality)", 7, 2 },
                    { 148, 78, "Purchase via Mogstation for $5 / €3.50", "Ominous Prognisticks (Orchestral Version)", 6, 2 },
                    { 156, 78, "Buying the \"Primals Zepp Tour 2018\" Blu-Ray", "Rise (The Primals)", 14, 2 },
                    { 147, 78, "Purchase via Mogstation for $5 / €3.50", "Calamity Unbound (Orchestral Version)", 5, 2 },
                    { 145, 78, "Purchase via Mogstation for $5 / €3.50", "Rise of the White Raven (Orchestral)", 3, 2 },
                    { 144, 78, "Purchase via Mogstation for $5 / €3.50", "Revenge Twofold (Orchestral)", 2, 2 },
                    { 143, 78, "Purchase via Mogstation for $5 / €3.50", "Oblivion (Orchestral)", 1, 2 },
                    { 142, 78, "Bought from Enie in The Firmament for 1,200 Skybuilders' Scrips", "Safety In Numbers", 90, 7 },
                    { 141, 78, "Bought from Jul Oul in Il Mheg for 6 Fae Fancy.", "The Garden's Gates", 89, 7 },
                    { 140, 78, "Bought from Goushs Ooan in the Tempest for 350 Bicolor Gemstones.", "Neath Dark Waters", 88, 7 },
                    { 139, 78, "Bought from Nacille in The Rak'tika Greatwood for 350 Bicolor Gemstones.", "A Hopeless Race", 87, 7 },
                    { 138, 78, "Bought from Sul Lad in Il Mheg for 350 Bicolor Gemstones.", "The Faerie Ring", 86, 7 },
                    { 146, 78, "Purchase via Mogstation for $5 / €3.50", "Serenity (Orchestral Version)", 4, 2 },
                    { 157, 78, "Currently Unknown", "Moebius (Orchestral Version)", 15, 2 },
                    { 158, 78, "Currently Unknown", "Painted Foothills (Orchestral Version)", 16, 2 },
                    { 159, 78, "Buying \"The Best\" Album", "Wayward Daughter (Chiptune Version)", 17, 2 },
                    { 178, 78, "Teleportation ward for The Aquapolis randomly spawns after the completion of a Timeworn Dragonskin Map.", "Calamity Unbound", 16, 3 },
                    { 177, 78, "Add 100 unique music rolls to your orchestrion.", "The Seventh Sun", 15, 3 },
                    { 176, 78, "Reward for the quest Litany of Peace.", "Dragonsong", 14, 3 },
                    { 175, 78, "Add 50 unique music rolls to your orchestrion.", "Defender of the Realm", 13, 3 },
                    { 174, 78, "Crafted by Level 60 Alchemist (Master Alchemist III) with Faded Copy of Engage, obtained from exploratory voyages in Sea of Clouds - Sector 18.", "Engage", 12, 3 },
                    { 173, 78, "Purchased from Hismena in Idyllshire for 375 Allagan Tomestones of Poetics.", "Ominous Prognisticks", 11, 3 },
                    { 172, 78, "Crafted by Level 60 Alchemist (Master Alchemist III) with Faded Copy of Starved, bought from the Materia Provisioner at the Wolves' Den Pier for 10,000 Wolf Marks.", "Starved", 10, 3 },
                    { 171, 78, "Crafted by Level 60 Alchemist (Master Alchemist III) from Faded Copy of Blood for Blood, bought from the Materia Provisioner at the Wolves' Den Pier for 5,000 Wolf Marks.", "Blood for Blood", 9, 3 },
                    { 170, 78, "Purchased from the Amber Trader in Foundation for 10 Amber-encased Vilekin.", "When a Tree Falls", 8, 3 },
                    { 169, 78, "Purchased from the Amber Trader in Foundation for 5 Amber-encased Vilekin.", "Tenacity", 7, 3 },
                    { 168, 78, "Crafted by Level 50 Alchemist with Faded Copy of A World Apart, obtained from exploratory voyages in Sea of Clouds - Sector 23.", "A World Apart", 6, 3 },
                    { 167, 78, "Crafted by Level 50 Alchemist with Faded Copy of The Only Path, dropped from Timeworn Wyvernskin Maps.", "The Only Path", 5, 3 },
                    { 166, 78, "Bought from the Gold Saucer Attendant <Prize Claim> at the Gold Saucer for 30,000 MGP.", "Agent of Inquiry", 4, 3 },
                    { 165, 78, "Purchased from Hismena in Idyllshire for 375 Allagan Tomestones of Poetics.", "Contention", 3, 3 },
                    { 164, 78, "Bought from the Gold Saucer Attendant <Prize Claim> at the Gold Saucer for 5,000 MGP.", "A Cold Wind", 2, 3 },
                    { 163, 78, "Add 10 unique music rolls to your orchestrion.", "Prelude - Discoveries", 1, 3 },
                    { 162, 78, "Buying \"Eorzean Symphony: Final Fantasy XIV Orchestral Album Vol. 2\" Album", "Tsukuyomi's Pain (Orchestral Version)", 20, 2 },
                    { 161, 78, "Buying \"Eorzean Symphony: Final Fantasy XIV Orchestral Album Vol. 2\" Album", "The Worm's Tail (Orchestral Version)", 19, 2 },
                    { 160, 78, "Buying \"The Best\" Album", "The Worm's Tail (Chiptune Version)", 18, 2 },
                    { 137, 78, "Bought from Halden in Amh Araeng for 350 Bicolor Gemstones.", "Sands of Blood", 85, 7 },
                    { 136, 78, "Bought from Zumutt in Kholusia for 350 Bicolor Gemstones.", "The Quick Way", 84, 7 },
                    { 135, 78, "Bought from Siulmet in Lakeland for 350 Bicolor Gemstones.", "Unchanging, Everchanging", 83, 7 },
                    { 134, 78, "Reward for the quest Moving Forward.", "Pain in Pleasure", 82, 7 },
                    { 110, 78, "Bought from the Kojin Beast Tribe for 3 Kojin sango at Rank 6.", "Indomitable", 58, 7 },
                    { 109, 78, "Teleportation ward for the Hidden Canals of Uznair spawns after using the action Dig near the location shown on a Timeworn Thief's Map.", "A Father's Pride", 57, 7 },
                    { 108, 78, "Exchanged at a Scrip Exchange for 400 Yellow Gatherers' Scrips.", "Songs of Salt and Suffering", 56, 7 },
                    { 107, 78, "Exchanged at a Scrip Exchange for 400 Yellow Crafters' Scrips.", "On High", 55, 7 },
                    { 106, 78, "Teleportation ward for the Hidden Canals of Uznair spawns after using the action Dig near the location shown on a Timeworn Thief's Map.", "Crimson Sunrise", 54, 7 },
                    { 105, 78, "Bought from Enna in Rhalgr's Reach for 1,600 Tomestones of Creation.", "Impact", 53, 7 },
                    { 104, 78, "Reward for the quest A Blissful Arrival.", "The Measure of His Reach", 52, 7 },
                    { 103, 78, "Reward for the quest The Butcher's Blood.", "The Measure of Our Reach", 51, 7 },
                    { 102, 78, "Teleportation ward for the Lost Canals of Uznair randomly spawns after the completion of a Timeworn Gazelleskin Map, while the teleportation ward for the Hidden Canals of Uznair spawns after using the action Dig near the location shown on a Timeworn Thief's Map.", "The Twin Faces of Fate - The Theme of Ul'dah", 50, 7 },
                    { 101, 78, "Teleportation ward for the Lost Canals of Uznair randomly spawns after the completion of a Timeworn Gazelleskin Map, while the teleportation ward for the Hidden Canals of Uznair spawns after using the action Dig near the location shown on a Timeworn Thief's Map.", "Born of the Boughs - The Theme of Gridania", 49, 7 },
                    { 100, 78, "Teleportation ward for the Lost Canals of Uznair randomly spawns after the completion of a Timeworn Gazelleskin Map, while the teleportation ward for the Hidden Canals of Uznair spawns after using the action Dig near the location shown on a Timeworn Thief's Map.", "Navigator's Glory - The Theme of Limsa Lominsa", 48, 7 },
                    { 99, 78, "Purchased in Wineport in Eastern La Noscea.", "The Edge", 47, 7 },
                    { 98, 78, "Purchased for 300 Centurio Seals in Kugane.", "Drowning in the Horizon", 46, 7 },
                    { 97, 78, "Drops from the FATE Never Say Daimyo upon completion.", "Liquid Flame", 45, 7 },
                    { 96, 78, "Drops from the FATE The Evil Seed upon completion.", "Beyond the Wall", 44, 7 },
                    { 95, 78, "Crafted - ALC Lv60 - 1x Blank Grade 3 Orchestrion Roll, 1x Enchanted Mythrite Ink, 1x Faded Copy of Missing Pages (drops from Hunts in Dravanian Hinterlands).", "The Silent Regard of Stars", 43, 7 },
                    { 94, 78, "Crafted - ALC Lv60 - 1x Blank Grade 3 Orchestrion Roll, 1x Enchanted Mythrite Ink, 1x Faded Copy of Landlords (drops from Hunts in Churning Mists).", "Skylords", 42, 7 },
                    { 93, 78, "Purchased from Ardolain in Foundation for 300 Centurio Seals.", "Thicker than a Knife's Blade", 41, 7 },
                    { 92, 78, "Purchased from the Merchant & Mender in Aleport for 5,000 Gil.", "Saltswept", 40, 7 },
                    { 111, 78, "Teleportation ward for the Hidden Canals of Uznair spawns after using the action Dig near the location shown on a Timeworn Thief's Map.", "Crimson Sunset", 59, 7 },
                    { 359, 78, "Level 80★ Alchemist (Master Alchemist VI) from Faded Copy of From the Crown of the Immaculate (Extreme)", "Insanity", 38, 6 },
                    { 112, 78, "Bought from Enna in Rhalgr's Reach for 1,600 Tomestones of Creation.", "Westward Tide", 60, 7 },
                    { 114, 78, "Bought from Enna in Rhalgr's Reach for 1,600 Tomestones of Creation.", "He Rises Above", 62, 7 },
                    { 133, 78, "Bought from Pedronille in Eulmore for 350 Bicolor Gemstones.", "Masquerade", 81, 7 },
                    { 132, 78, "Bought from Gramsol in the Crystarium for 350 Bicolor Gemstones.", "Knowledge Never Sleeps", 80, 7 },
                    { 131, 78, "Bought from Goushs Ooan in the Tempest for 350 Bicolor Gemstones.", "Full Fathom Five", 79, 7 },
                    { 130, 78, "Bought from Nacille in The Rak'tika Greatwood for 350 Bicolor Gemstones.", "Civilizations", 78, 7 },
                    { 129, 78, "Bought from Sul Lad in Il Mheg for 350 Bicolor Gemstones.", "Fierce and Free", 77, 7 },
                    { 128, 78, "Bought from Halden in Amh Araeng for 350 Bicolor Gemstones.", "Sands of Amber", 76, 7 },
                    { 127, 78, "Bought from Zumutt in Kholusia for 350 Bicolor Gemstones.", "A World Divided", 75, 7 },
                    { 126, 78, "Bought from Siulmet in Lakeland for 350 Bicolor Gemstones.", "The Source", 74, 7 },
                    { 125, 78, "Bought from Pedronille in Eulmore for 350 Bicolor Gemstones.", "Indulgence", 73, 7 },
                    { 124, 78, "Bought from Gramsol in the Crystarium for 350 Bicolor Gemstones.", "Thw Dark Which Illuminates the World", 72, 7 }
                });

            migrationBuilder.InsertData(
                table: "OrchestrionTask",
                columns: new[] { "Id", "CategoryId", "Method", "Name", "Number", "OrchestrionTypeId" },
                values: new object[,]
                {
                    { 123, 78, "Exchanged at a Scrip Exchange for 200 Yellow Crafters' Scrips.", "Harmony", 71, 7 },
                    { 122, 78, "Exchanged at a Scrip Exchange for 200 Yellow Gatherers' Scrips.", "Old Wounds", 70, 7 },
                    { 121, 78, "Exchanged at a Scrip Exchange for 200 Yellow Gatherers' Scrips.", "The Stone Remembers", 69, 7 },
                    { 120, 78, "Exchanged at a Scrip Exchange for 200 Yellow Gatherers' Scrips.", "Hope Forgotten", 68, 7 },
                    { 119, 78, "Exchanged at a Scrip Exchange for 200 Yellow Crafters' Scrips.", "Afterglow", 67, 7 },
                    { 118, 78, "Purchased from Junkmonger", "Cradle", 66, 7 },
                    { 117, 78, "Bought from Gyosho for 3 Namazu Koban.", "Seven Hundred Seventy-Seven Whiskers", 65, 7 },
                    { 116, 78, "Crafted by Level 60 (Master Alchemist III) with Faded Copy of Against the Wind.", "Black and White", 64, 7 },
                    { 115, 78, "Bought from the Ananta Beast Tribe for 3 Ananta dreamstaves at Rank 6.", "Keepers of the Lock", 63, 7 },
                    { 113, 78, "Teleportation ward for the Hidden Canals of Uznair spawns after using the action Dig near the location shown on a Timeworn Thief's Map.", "Mother's Pride", 61, 7 },
                    { 360, 78, "Level 80★★ Alchemist (Master Alchemist VII) from Faded Copy of From The Minstrel's Ballad: Hades's Elegy", "Invincible", 39, 6 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Category_OrchestrionTasks",
                table: "OrchestrionTask",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrchestrionType_OrchestrionTasks",
                table: "OrchestrionTask",
                column: "OrchestrionTypeId",
                principalTable: "OrchestrionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_OrchestrionTasks",
                table: "OrchestrionTask");

            migrationBuilder.DropForeignKey(
                name: "FK_OrchestrionType_OrchestrionTasks",
                table: "OrchestrionTask");

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "OrchestrionTask",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.AddForeignKey(
                name: "FK_OrchestrionTask_Category_CategoryId",
                table: "OrchestrionTask",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrchestrionTask_OrchestrionType_OrchestrionTypeId",
                table: "OrchestrionTask",
                column: "OrchestrionTypeId",
                principalTable: "OrchestrionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
