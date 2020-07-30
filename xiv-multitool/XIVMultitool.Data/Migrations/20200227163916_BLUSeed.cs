using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XIVChecklist.Data.Migrations
{
    public partial class BLUSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BLUCarnivaleTask",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Stage = table.Column<int>(nullable: false),
                    StandardMinute = table.Column<string>(nullable: true),
                    StandardSecond = table.Column<string>(nullable: true),
                    IdealMinute = table.Column<string>(nullable: true),
                    IdealSecond = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BLUCarnivaleTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BLUCarnivaleTask_Category",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BLULogTask",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ContentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BLULogTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BLULogTask_Category",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BLULogTask_PvEContent",
                        column: x => x.ContentId,
                        principalTable: "PvEContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BLUSpellTask",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BLUSpellTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BLUSpellTask_Category",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BLUSpellLocation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BLUSpellTaskId = table.Column<int>(nullable: false),
                    MobName = table.Column<string>(nullable: true),
                    LocationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BLUSpellLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BLUSpellLocation_BLUSpellTask",
                        column: x => x.BLUSpellTaskId,
                        principalTable: "BLUSpellTask",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentCategoryId", "Position" },
                values: new object[] { 69, "Blue Mage", null, 1 });

            migrationBuilder.UpdateData(
                table: "PvEContent",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "The Tam-Tara Deepcroft (Hard)");

            migrationBuilder.InsertData(
                table: "PvEContent",
                columns: new[] { "Id", "Level", "Name", "PvEContentTypeId", "iLevel" },
                values: new object[,]
                {
                    { 183, 60, "Alexander - The Arm of the Father", 2, 170 },
                    { 184, 60, "Alexander - The Burden of the Father", 2, 170 },
                    { 185, 60, "Alexander - The Arm of the Son", 2, 200 },
                    { 186, 60, "Alexander - The Burden of the Son", 2, 200 },
                    { 187, 60, "Alexander - The Heart of the Creator", 2, 230 },
                    { 188, 60, "Alexander - The Soul of the Creator", 2, 230 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentCategoryId", "Position" },
                values: new object[] { 70, "Masked Carnivale", 69, 2 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentCategoryId", "Position" },
                values: new object[] { 71, "BLU Log", 69, 2 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentCategoryId", "Position" },
                values: new object[] { 72, "Spellbook", 69, 2 });

            migrationBuilder.InsertData(
                table: "BLUCarnivaleTask",
                columns: new[] { "Id", "CategoryId", "IdealMinute", "IdealSecond", "Name", "Stage", "StandardMinute", "StandardSecond" },
                values: new object[,]
                {
                    { 1, 70, "0", "20", "All's Well That Starts Well", 1, "0", "30" },
                    { 29, 70, "7", "00", "Red, Fraught, and Blue", 29, "8", "00" },
                    { 28, 70, "5", "00", "Dangerous When Dead", 28, "6", "00" },
                    { 27, 70, "2", "20", "Lock Up Your Snorters", 27, "4", "00" },
                    { 26, 70, "4", "00", "Papa Mia", 26, "5", "00" },
                    { 25, 70, "7", "15", "Dirty Rotten Azulmagia", 25, "8", "45" },
                    { 24, 70, "5", "40", "Amazing Technicolor Pit Fiends", 24, "6", "45" },
                    { 23, 70, "3", "45", "Behemoths and Broomsticks", 23, "5", "00" },
                    { 22, 70, "4", "00", "Here Comes the Boom", 22, "5", "00" },
                    { 21, 70, "3", "15", "Chimera on a Hot Tin Roof", 21, "4", "15" },
                    { 20, 70, "5", "10", "Miss Typhon", 20, "6", "00" },
                    { 19, 70, "4", "00", "On a Clear Day You Can Smell Forever", 19, "5", "00" },
                    { 18, 70, "4", "20", "Midsummer Night's Explotion", 18, "6", "00" },
                    { 17, 70, "4", "15", "The Sword of Music", 17, "5", "30" },
                    { 16, 70, "3", "30", "Sunset Bull-evard", 16, "4", "30" },
                    { 30, 70, "6", "30", "The Catch of Siegfried", 30, "7", "30" },
                    { 14, 70, "2", "30", "Blobs in the Woods", 14, "3", "00" },
                    { 2, 70, "2", "30", "Much Ado About Pudding", 2, "3", "30" },
                    { 3, 70, "2", "45", "Waiting For Golem", 3, "3", "45" },
                    { 4, 70, "2", "35", "Gentlemen Prefer Swords", 4, "3", "30" },
                    { 15, 70, "3", "45", "The Me Nobody Nodes", 15, "4", "45" },
                    { 6, 70, "2", "25", "Eye Society", 6, "3", "20" },
                    { 7, 70, "2", "40", "A Chorus Slime", 7, "3", "30" },
                    { 5, 70, "0", "45", "The Threepenny Turtles", 5, "1", "20" },
                    { 9, 70, "3", "30", "To Kill a Mockingslime", 9, "4", "45" },
                    { 10, 70, "3", "10", "A Little Knight Music", 10, "4", "30" },
                    { 11, 70, "2", "30", "Some Like It Excrutiatingly Hot", 11, "3", "30" },
                    { 12, 70, "3", "10", "The Plant-om of the Opera", 12, "4", "30" },
                    { 13, 70, "3", "30", "Beauty and a Beast", 13, "4", "30" },
                    { 8, 70, "2", "45", "The Bomb-edy of Errors", 8, "3", "45" }
                });

            migrationBuilder.InsertData(
                table: "BLULogTask",
                columns: new[] { "Id", "CategoryId", "ContentId", "Name" },
                values: new object[,]
                {
                    { 45, 71, 102, "57" },
                    { 44, 71, 101, "53" },
                    { 43, 71, 93, "50" },
                    { 42, 71, 91, "50" },
                    { 41, 71, 90, "50" },
                    { 34, 71, 48, "60" },
                    { 39, 71, 88, "50" },
                    { 38, 71, 87, "50" },
                    { 37, 71, 86, "50" },
                    { 36, 71, 85, "50" },
                    { 35, 71, 49, "60" },
                    { 46, 71, 103, "60" },
                    { 40, 71, 89, "50" },
                    { 47, 71, 104, "60" },
                    { 54, 71, 183, "60" },
                    { 49, 71, 106, "60" },
                    { 50, 71, 107, "60" },
                    { 51, 71, 159, "50" },
                    { 52, 71, 160, "50" },
                    { 53, 71, 161, "50" },
                    { 55, 71, 184, "60" },
                    { 57, 71, 186, "60" },
                    { 58, 71, 187, "60" },
                    { 59, 71, 188, "60" },
                    { 60, 71, 162, "60" },
                    { 61, 71, 163, "60" },
                    { 62, 71, 164, "60" },
                    { 33, 71, 47, "60" },
                    { 48, 71, 105, "60" },
                    { 32, 71, 46, "60" },
                    { 56, 71, 185, "60" },
                    { 30, 71, 44, "60" },
                    { 31, 71, 45, "60" },
                    { 1, 71, 15, "50" },
                    { 2, 71, 16, "50" },
                    { 3, 71, 17, "50" },
                    { 4, 71, 18, "50" },
                    { 5, 71, 19, "50" },
                    { 6, 71, 20, "50" },
                    { 7, 71, 21, "50" },
                    { 8, 71, 22, "50" },
                    { 9, 71, 23, "50" },
                    { 10, 71, 25, "50" },
                    { 11, 71, 24, "50" },
                    { 13, 71, 27, "50" },
                    { 14, 71, 28, "50" },
                    { 12, 71, 26, "50" },
                    { 16, 71, 30, "50" },
                    { 29, 71, 43, "60" },
                    { 28, 71, 42, "60" },
                    { 27, 71, 41, "60" },
                    { 26, 71, 40, "60" },
                    { 25, 71, 39, "60" },
                    { 15, 71, 29, "50" },
                    { 23, 71, 37, "60" },
                    { 24, 71, 38, "60" },
                    { 22, 71, 36, "59" },
                    { 21, 71, 35, "57" },
                    { 20, 71, 34, "55" },
                    { 19, 71, 33, "53" },
                    { 18, 71, 32, "51" },
                    { 17, 71, 31, "50" }
                });

            migrationBuilder.InsertData(
                table: "BLUSpellTask",
                columns: new[] { "Id", "CategoryId", "Name", "Number" },
                values: new object[,]
                {
                    { 52, 72, "Northerlies", 52 },
                    { 56, 72, "Chirp", 56 },
                    { 55, 72, "Abyssal Transfixion", 55 },
                    { 54, 72, "Kaltstrahl", 54 },
                    { 53, 72, "Electrogenesis", 53 },
                    { 57, 72, "Eerie Soundwave", 57 },
                    { 51, 72, "Protean Wave", 51 },
                    { 42, 72, "Doom", 42 },
                    { 49, 72, "Veil Of The Whorl", 49 },
                    { 48, 72, "Glass Dance", 48 },
                    { 47, 72, "Shock Strike", 47 },
                    { 46, 72, "Mountain Buster", 46 },
                    { 45, 72, "Eruption", 45 },
                    { 44, 72, "Feather Rain", 44 },
                    { 43, 72, "Peculiar Light", 43 },
                    { 58, 72, "Pom Cure", 58 },
                    { 50, 72, "Alpine Draft", 50 },
                    { 59, 72, "Gobskin", 59 },
                    { 74, 72, "Reflex", 74 },
                    { 61, 72, "Avail", 61 },
                    { 78, 72, "Surpanakha", 78 },
                    { 77, 72, "Aetherial Mimicry", 77 },
                    { 76, 72, "Condensed Libra", 76 },
                    { 75, 72, "Devour", 75 },
                    { 41, 72, "Mind Blast", 41 },
                    { 73, 72, "Exuviation", 73 },
                    { 72, 72, "Angel Whisper", 72 },
                    { 71, 72, "Revenge Blast", 71 },
                    { 70, 72, "Cactguard", 70 },
                    { 69, 72, "Perpetual Ray", 69 },
                    { 68, 72, "Launcher", 68 },
                    { 67, 72, "Level 5 Death", 67 },
                    { 66, 72, "Black Knight's Tour", 66 },
                    { 65, 72, "White Knight's Tour", 65 },
                    { 64, 72, "Whistle", 64 },
                    { 63, 72, "Sonic Boom", 63 },
                    { 62, 72, "Frog Legs", 62 },
                    { 60, 72, "Magic Hammer", 60 },
                    { 40, 72, "Tail Screw", 40 },
                    { 25, 72, "Snort", 25 },
                    { 38, 72, "Fire Angon", 38 },
                    { 15, 72, "Sharpened Knife", 15 },
                    { 14, 72, "Level 5 Petrify", 14 },
                    { 13, 72, "White Wind", 13 },
                    { 12, 72, "Bristle", 12 },
                    { 11, 72, "Plaincracker", 11 },
                    { 10, 72, "Glower", 10 },
                    { 9, 72, "Song of Torment", 9 },
                    { 16, 72, "Ice Spikes", 16 },
                    { 8, 72, "Final Sting", 8 },
                    { 6, 72, "High Voltage", 6 },
                    { 5, 72, "Drill Cannons", 5 },
                    { 4, 72, "Flying Frenzy", 4 },
                    { 3, 72, "Aqua Breath", 3 },
                    { 2, 72, "Flame Thrower", 2 },
                    { 1, 72, "Water Cannon", 1 },
                    { 79, 72, "Quasar", 79 },
                    { 7, 72, "Loom", 7 },
                    { 17, 72, "Blood Drain", 17 },
                    { 18, 72, "Acorn Bomb", 18 },
                    { 19, 72, "Bomb Toss", 19 },
                    { 37, 72, "Ink Jet", 37 },
                    { 36, 72, "1000 Needles", 36 },
                    { 35, 72, "Missile", 35 },
                    { 34, 72, "The Dragon's Voice", 34 },
                    { 33, 72, "The Ram's Voice", 33 },
                    { 32, 72, "Toad Oil", 32 },
                    { 31, 72, "Sticky Tongue", 31 },
                    { 30, 72, "Mighty Guard", 30 },
                    { 29, 72, "Diamondback", 29 },
                    { 28, 72, "Bad Breath", 28 },
                    { 27, 72, "The Look", 27 },
                    { 26, 72, "4-Tonze Weight", 26 },
                    { 24, 72, "Flying Sardine", 24 },
                    { 23, 72, "Faze", 23 },
                    { 22, 72, "Transfusion", 22 },
                    { 21, 72, "Self-Destruct", 21 },
                    { 20, 72, "Off-Guard", 20 },
                    { 39, 72, "Moon Flute", 39 },
                    { 80, 72, "J Kick", 80 }
                });

            migrationBuilder.InsertData(
                table: "BLUSpellLocation",
                columns: new[] { "Id", "BLUSpellTaskId", "LocationName", "MobName" },
                values: new object[,]
                {
                    { 1, 1, "Starting Spell", "" },
                    { 74, 55, "The Dravanian Hinterlands (Levequest: Necrologos: His Treasure Forbidden Leve)", "Arch Demon" },
                    { 73, 55, "Haukke Manor (Hard)", "Ash" },
                    { 72, 54, "Alexander - The Cuff of the Father", "Jagd Doll" },
                    { 71, 54, "Alexander - The Fist of the Father", "Faust" },
                    { 70, 53, "Sea of Clouds", "Conodont" },
                    { 69, 52, "Coerthas Western Highlands", "Slate Yeti" },
                    { 68, 51, "Masked Carnivale #29", "Shikigami" },
                    { 67, 51, "Alexander - The Arm of the Father", "Living Liquid" },
                    { 66, 50, "Sea of Clouds", "Griffin" },
                    { 65, 49, "The Whorleater", "Leviathan" },
                    { 64, 48, "Akh Afah Amphitheatre (Extreme)", "Shiva" },
                    { 63, 47, "The Striking Tree (Hard)", "Ramuh" },
                    { 62, 46, "The Navel (Hard)", "Titan" },
                    { 61, 45, "The Bowl of Embers", "Ifrit" },
                    { 60, 44, "The Howling Eye (Extreme)", "Garuda" },
                    { 59, 43, "Mor Dhona", "Lentic Mudpuppy" },
                    { 58, 42, "Complete 20 Stages in the Masked Carnivale", "" },
                    { 57, 41, "The Tam-Tara Deepcroft", "Galvanth the Dominator" },
                    { 56, 40, "The Peaks", "Clay Claw" },
                    { 55, 40, "Sastasha (Hard)", "Karlabos" },
                    { 54, 39, "Complete 10 Stages in the Masked Carnivale", "" },
                    { 75, 55, "The Great Gubal Library", "Biblioklept" },
                    { 76, 56, "Sea of Clouds", "Paissa" },
                    { 77, 57, "Azys Lla", "Empuse" },
                    { 78, 58, "Thornmarch (Hard)", "Furryfoot Kupli Kipp" },
                    { 100, 78, "Thok Ast Thok", "Ravana" },
                    { 99, 77, "Pharos Sirius (Hard)", "Ghrah Luminary Adds" },
                    { 98, 76, "Masked Carnivale #24", "Arena Scribe" },
                    { 97, 75, "The Banding Coil of Bahamut Turn 1", "Caduceus" },
                    { 96, 74, "The Churning Mists", "Cloud Wyvern" },
                    { 95, 73, "Sea of Clouds", "Abalatian Wamoura" },
                    { 94, 72, "Complete 30 Stages at the Masked Carnivale", "" },
                    { 93, 71, "Learn 50 Spells", "" },
                    { 92, 70, "The Sunken Temple of Qarn (Hard)", "Sabotender Gaurdia" },
                    { 91, 69, "Alexander - The Burden of the Father", "The Manipulator" },
                    { 53, 38, "The Wanderer's Palace (Hard)", "Fruminious Koheel Ja" },
                    { 90, 68, "Baelsar's Wall", "Armored Weapon" },
                    { 88, 66, "The Vault", "Black Knight" },
                    { 87, 65, "The Vault", "White Knight" },
                    { 86, 64, "Sea of Clouds", "Dhalmel" },
                    { 85, 63, "Sea of Clouds", "Anzu" },
                    { 84, 62, "The Dravanian Hinterlands", "Poroggo" },
                    { 83, 61, "Saint Mocianne's Arboretum", "Queen Hawk" },
                    { 82, 60, "Masked Carnivale #24", "Epilogi" },
                    { 81, 60, "The Great Gubal Library (Hard)", "Apanda" },
                    { 80, 59, "The Dravanian Hinterlands", "Slipkinx Steeljoints (A Rank)" },
                    { 79, 59, "Alexander - The Breath of the Creator", "Alexander Hider" },
                    { 89, 67, "The Great Gubal Library", "Page 64" },
                    { 52, 37, "Sastasha (Hard)", "Kraken" },
                    { 51, 36, "Southern Thanalan", "Sabotender Bailaor" },
                    { 50, 35, "Battle in the Big Keep", "Enkidu" },
                    { 23, 17, "Lower La Noscea", "Cave Bat" },
                    { 22, 16, "Central Shroud", "Trickster Imp" },
                    { 21, 15, "The Wanderer's Palace", "Tonberry King" },
                    { 20, 14, "Haukke Manor", "Manor Sentry" },
                    { 19, 13, "Learn 10 Spells", "" },
                    { 18, 12, "East Shroud", "Wild Boar" },
                    { 17, 11, "Southern Thanalan", "Sandstone Golem" },
                    { 16, 11, "Outer La Noscea", "Basalt Golem" },
                    { 15, 10, "The Aurum Vale", "Coincounter" },
                    { 14, 9, "Pharos Sirius", "Siren" },
                    { 24, 18, "North Shroud", "Treant Sapling" },
                    { 13, 8, "Middle La Noscea", "Killer Waspe" },
                    { 11, 7, "The Lost City of Amdapoor", "Baalzephon" },
                    { 10, 7, "Northern Thanalan", "Flame Serpant Dalvag" },
                    { 9, 6, "Masked Carnival #15", "Bestial Node" },
                    { 8, 6, "The Binding Coil of Bahamut Turn 1", "ADS" },
                    { 7, 5, "Northern Thanalan", "Magitek Vanguard H-2" },
                    { 6, 4, "Pharos Sirius", "Zu" },
                    { 5, 3, "The Whorleater", "Leviathan" },
                    { 4, 3, "The Dragon's Neck", "Ultros" },
                    { 3, 2, "The Keeper of the Lake", "Einhander" },
                    { 2, 2, "Brayflox's Longstop (Hard)", "Gobmachine G-VI" },
                    { 12, 7, "The Tam-Tara Deepcroft (Hard)", "Dantalion" },
                    { 101, 79, "Containment Bay P1T6", "Sophia" },
                    { 25, 19, "Middle La Noscea", "Goblin Fisher" },
                    { 27, 20, "Learn 5 Spells", "" },
                    { 49, 34, "The Masked Carnivale #25", "Azulmagia" },
                    { 48, 34, "A Relic Reborn: The Chimera", "Dhorme Chimera" },
                    { 47, 34, "Cutter's Cry", "Chimera" },
                    { 46, 33, "The Masked Carnivale #25", "Azulmagia" },
                    { 45, 33, "A Relic Reborn: The Chimera", "Dhorme Chimera" },
                    { 44, 33, "Cutter's Cry", "Chimera" },
                    { 43, 32, "Western Thanalan", "Giggling Gigantoad" },
                    { 42, 31, "Western Thanalan", "Laughing Toad" },
                    { 41, 31, "Central Thanalan", "Toxic Toad" },
                    { 40, 30, "Learn 10 Spells", "" },
                    { 26, 19, "Middle La Noscea", "Goblin Gambler" },
                    { 39, 29, "The Steps of Faith", "Horde Armored Dragon" },
                    { 37, 28, "Mor Dhona", "Morbol" },
                    { 36, 28, "Central Shroud", "Stroper" },
                    { 35, 27, "Amdapoor Keep", "Anantaboga" },
                    { 34, 26, "The Dragon's Neck", "Ultros" },
                    { 33, 25, "The Masked Carnivale", "Typhon" },
                    { 32, 25, "The Dragon's Neck", "Typhon" },
                    { 31, 24, "Eastern La Noscea", "Apkallu" },
                    { 30, 23, "Central Thanalan", "Qiqirn Shellsweeper" },
                    { 29, 22, "Learn 20 Spells", "" },
                    { 28, 21, "Western Thanalan", "Glide Bomb" },
                    { 38, 29, "The Stone Vigil (Hard)", "Cuca Fera" },
                    { 102, 80, "Alexander - The Burden of the Son", "Brute Justice" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PvEContent_PvEContentTypeId",
                table: "PvEContent",
                column: "PvEContentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BLUCarnivaleTask_CategoryId",
                table: "BLUCarnivaleTask",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BLULogTask_CategoryId",
                table: "BLULogTask",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BLULogTask_ContentId",
                table: "BLULogTask",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_BLUSpellLocation_BLUSpellTaskId",
                table: "BLUSpellLocation",
                column: "BLUSpellTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_BLUSpellTask_CategoryId",
                table: "BLUSpellTask",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PvEContent_PvEContentType_PvEContentTypeId",
                table: "PvEContent",
                column: "PvEContentTypeId",
                principalTable: "PvEContentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PvEContent_PvEContentType_PvEContentTypeId",
                table: "PvEContent");

            migrationBuilder.DropTable(
                name: "BLUCarnivaleTask");

            migrationBuilder.DropTable(
                name: "BLULogTask");

            migrationBuilder.DropTable(
                name: "BLUSpellLocation");

            migrationBuilder.DropTable(
                name: "BLUSpellTask");

            migrationBuilder.DropIndex(
                name: "IX_PvEContent_PvEContentTypeId",
                table: "PvEContent");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PvEContent",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "PvEContent",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "PvEContent",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "PvEContent",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "PvEContent",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "PvEContent",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.UpdateData(
                table: "PvEContent",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "The Tam-Tara-Deepcroft (Hard)");
        }
    }
}
