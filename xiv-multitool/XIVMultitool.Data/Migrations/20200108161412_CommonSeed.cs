using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XIVChecklist.Data.Migrations
{
    public partial class CommonSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Discipline",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Abbreviation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discipline", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expansion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expansion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeveType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeveType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PvEContent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PvEContentTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    iLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PvEContent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PvEContentType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PvEContentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SightseeingEmote",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SightseeingEmote", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RegionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zone_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ZoneId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_Zone_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Discipline",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[,]
                {
                    { 1, "WAR", "Warrior" },
                    { 17, "DNC", "Dancer" },
                    { 16, "BRD", "Bard" },
                    { 15, "DRG", "Dragoon" },
                    { 14, "NIN", "Ninja" },
                    { 13, "SAM", "Samurai" },
                    { 11, "SMN", "Summoner" },
                    { 10, "BLU", "Blue Mage" },
                    { 12, "MNK", "Monk" },
                    { 8, "RDM", "Red Mage" },
                    { 7, "AST", "Astrologist" },
                    { 6, "SCH", "Scholar" },
                    { 5, "WHM", "White Mage" },
                    { 4, "GNB", "Gunbreaker" },
                    { 3, "DRK", "Dark Knight" },
                    { 2, "PLD", "Paladin" },
                    { 9, "BLM", "Black Mage" }
                });

            migrationBuilder.InsertData(
                table: "Expansion",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "A Realm Reborn" },
                    { 2, "Heavensward" },
                    { 3, "Stormblood" },
                    { 4, "Shadowbringers" }
                });

            migrationBuilder.InsertData(
                table: "LeveType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Maelstrom" },
                    { 6, "Twin Adder" },
                    { 4, "Flames" },
                    { 2, "Tradecraft" },
                    { 1, "Battlecraft" },
                    { 3, "Fieldcraft" }
                });

            migrationBuilder.InsertData(
                table: "PvEContent",
                columns: new[] { "Id", "Level", "Name", "PvEContentTypeId", "iLevel" },
                values: new object[,]
                {
                    { 108, 60, "The Limitless Blue (Extreme)", 3, 165 },
                    { 109, 60, "Thok ast Thok (Extreme)", 3, 175 },
                    { 110, 60, "The Minstrel's Ballad: Thordan's Reign", 3, 190 },
                    { 111, 60, "The Minstrel's Ballad: Nidhogg's Rage", 3, 220 },
                    { 112, 60, "Containment Bay S1T7 (Extreme)", 3, 205 },
                    { 113, 60, "Containment Bay P1T6 (Extreme)", 3, 235 },
                    { 114, 60, "Containment Bay Z1T9 (Extreme)", 3, 250 },
                    { 115, 63, "The Pool of Tribute", 3, 0 },
                    { 116, 67, "Emanation", 3, 0 },
                    { 117, 70, "The Royal Menagerie", 3, 280 },
                    { 119, 70, "Castrum Fluminis", 3, 335 },
                    { 120, 70, "The Great Hunt", 3, 320 },
                    { 121, 70, "Hells' Kier", 3, 355 },
                    { 122, 70, "The Wreath of Snakes", 3, 365 },
                    { 123, 70, "Kugane Ohashi", 3, 365 },
                    { 124, 70, "The Pool of Tribute (Extreme)", 3, 300 },
                    { 125, 70, "Emanation (Extreme)", 3, 300 },
                    { 118, 70, "The Jade Stoa", 3, 325 },
                    { 107, 60, "Containment Bay Z1T9", 3, 235 },
                    { 93, 50, "The Minstrel's Ballad: Ultima's Bane", 3, 61 },
                    { 105, 60, "Containment Bay S1T7", 3, 190 },
                    { 87, 50, "The Navel (Hard)", 3, 57 },
                    { 88, 50, "Thornmarch (Hard)", 3, 54 },
                    { 89, 50, "The Whorleater (Hard)", 3, 60 },
                    { 90, 50, "The Striking Tree (Hard)", 3, 65 },
                    { 91, 50, "Akh Afah Amphitheatre (Hard)", 3, 80 },
                    { 92, 50, "Urth's Fount", 3, 95 },
                    { 126, 70, "The Minstrel's Ballad: Shinryu's Domain", 3, 320 },
                    { 94, 50, "The Howling Eye (Extreme)", 3, 65 },
                    { 106, 60, "Containment Bay P1T6", 3, 220 },
                    { 95, 50, "The Navel (Extreme)", 3, 67 },
                    { 97, 50, "Thornmarch (Extreme)", 3, 80 },
                    { 98, 50, "The Whorleater (Extreme)", 3, 80 },
                    { 99, 50, "The Striking Tree (Extreme)", 3, 85 },
                    { 100, 50, "Akh Afah Amphitheatre (Extreme)", 3, 95 },
                    { 101, 53, "Thok ast Thok (Hard)", 3, 0 },
                    { 102, 57, "The Limitless Blue (Hard)", 3, 0 },
                    { 103, 60, "The Singularity Reactor", 3, 142 },
                    { 104, 60, "The Final Steps of Faith", 3, 205 },
                    { 96, 50, "The Bowl of Embers (Extreme)", 3, 67 },
                    { 127, 70, "The Jade Stoa (Extreme)", 3, 340 },
                    { 140, 50, "The Second Coil of Bahamu (Savage)", 2, 90 },
                    { 129, 70, "The Great Hunt (Extreme)", 3, 350 },
                    { 152, 70, "Omega: Sigmascape (Savage)", 2, 340 },
                    { 153, 70, "The Minstrel's Ballad: The Weapon's Refrain (Ultimate)", 2, 370 },
                    { 154, 70, "Omega: Alphascape", 2, 355 },
                    { 155, 70, "Omega: Alphascape (Savage)", 2, 370 },
                    { 156, 80, "Eden's Gate", 2, 425 },
                    { 157, 80, "Eden's Gate (Savage)", 2, 440 },
                    { 158, 80, "The Epic of Alexander (Ultimate)", 2, 470 },
                    { 159, 50, "Labyrinth of the Ancients", 4, 50 },
                    { 160, 50, "Syrcus Tower", 4, 70 },
                    { 161, 50, "The World of Darkness", 4, 90 },
                    { 162, 60, "The Void Ark", 4, 175 },
                    { 163, 60, "The Weeping City of Mhach", 4, 205 },
                    { 164, 60, "Dun Scaith", 4, 235 },
                    { 165, 70, "The Royal City of Rabanastre", 4, 305 },
                    { 166, 70, "The Ridorana Lighthouse", 4, 335 },
                    { 167, 70, "The Orbonne Monastery", 4, 365 },
                    { 168, 80, "The Copied Factory", 4, 435 },
                    { 151, 70, "Omega: Sigmascape", 2, 325 },
                    { 150, 70, "The Unending Coil of Bahamut (Ultimate)", 2, 340 },
                    { 149, 70, "Omega: Deltascape (Savage)", 2, 310 },
                    { 148, 70, "Omega: Deltascape", 2, 295 },
                    { 130, 70, "Hells' Kier (Extreme)", 3, 370 },
                    { 131, 70, "The Wreath of Snakes (Extreme)", 3, 380 },
                    { 132, 73, "The Dancing Plague", 3, 0 },
                    { 133, 79, "The Crown of the Immaculate", 3, 0 },
                    { 134, 80, "The Dying Gasp", 3, 410 },
                    { 135, 80, "The Dancing Plague (Extreme)", 3, 430 },
                    { 136, 80, "The Crown of the Immaculate (Extreme)", 3, 430 },
                    { 137, 80, "The Minstrel's Ballad: Hades' Elegy", 3, 450 },
                    { 128, 70, "The Minstrel's Ballad: Tsukuyomi's Pain", 3, 350 },
                    { 138, 50, "The Binding Coil of Bahamut", 2, 70 },
                    { 86, 50, "The Howling Eye (Hard)", 3, 52 },
                    { 141, 50, "The Final Coil of Bahamut", 2, 90 },
                    { 142, 60, "Alexander: Gordias", 2, 170 },
                    { 143, 60, "Alexander: Gordia (Savage)", 2, 190 },
                    { 144, 60, "Alexander: Midas", 2, 200 },
                    { 145, 60, "Alexander: Midas (Savage)", 2, 215 },
                    { 146, 60, "Alexander: The Creator", 2, 230 },
                    { 147, 60, "Alexander: The Creator (Savage)", 2, 245 },
                    { 139, 50, "The Second Coil of Bahamut", 2, 90 },
                    { 85, 50, "The Bowl of Embers (Hard)", 3, 49 },
                    { 78, 50, "The Chrysalis", 3, 90 },
                    { 83, 50, "The Dragon's Neck", 3, 80 },
                    { 23, 50, "Hullbreaker Isle", 1, 70 },
                    { 24, 50, "The Stone Vigil (Hard)", 1, 70 },
                    { 25, 50, "The Tam-Tara-Deepcroft (Hard)", 1, 70 },
                    { 26, 50, "Snowcloak", 1, 80 },
                    { 27, 50, "Sastasha (Hard)", 1, 80 },
                    { 28, 50, "The Sunken Temple of Qarn (Hard)", 1, 80 },
                    { 29, 50, "The Keeper of the Lake", 1, 90 },
                    { 30, 50, "The Wanderer's Palace (Hard)", 1, 90 },
                    { 31, 50, "Amdapor Keep (Hard)", 1, 90 },
                    { 32, 51, "The Dusk Vigil", 1, 100 },
                    { 33, 53, "Sohm Al", 1, 105 },
                    { 34, 55, "The Aery", 1, 110 },
                    { 84, 50, "Battle in the Big Keep", 3, 90 },
                    { 36, 59, "The Great Gubal Library", 1, 120 },
                    { 37, 60, "The Aetherochemical Research Facility", 1, 142 },
                    { 38, 60, "Neverreap", 1, 145 },
                    { 39, 60, "The Fractal Continuum", 1, 145 },
                    { 22, 50, "Brayflox's Longstop (Hard)", 1, 55 },
                    { 21, 50, "Halatali (Hard)", 1, 55 },
                    { 20, 50, "The Lost City of Amdapor", 1, 55 },
                    { 19, 50, "Haukke Manor (Hard)", 1, 48 },
                    { 1, 15, "Sastasha", 1, 0 },
                    { 2, 16, "The Tam-Tara Deepcroft", 1, 0 },
                    { 3, 17, "Copperbell Mines", 1, 0 },
                    { 4, 20, "Halatali", 1, 0 },
                    { 5, 24, "The Thousand Maws of Toto-Rak", 1, 0 },
                    { 6, 28, "Haukke Manor", 1, 0 },
                    { 7, 32, "Brayflox's Longstop", 1, 0 },
                    { 8, 35, "The Sunken Temple of Karn", 1, 0 },
                    { 40, 60, "Saint Mocianne's Arboretum", 1, 170 },
                    { 9, 38, "Cutter's Cry", 1, 0 },
                    { 11, 44, "Dzemael Darkhold", 1, 0 },
                    { 12, 47, "The Aurum Vale", 1, 0 },
                    { 13, 50, "Castrum Meridianum", 1, 42 },
                    { 14, 50, "The Praetorium", 1, 42 },
                    { 15, 50, "The Wanderer's Palace", 1, 45 },
                    { 16, 50, "Amdapor Keep", 1, 45 },
                    { 17, 50, "Pharos Sirius", 1, 48 },
                    { 18, 50, "Copperbell Mines (Hard)", 1, 48 },
                    { 10, 41, "The Stone Vigil", 1, 0 },
                    { 41, 60, "Pharos Sirius (Hard)", 1, 170 },
                    { 35, 57, "The Vault", 1, 115 },
                    { 43, 60, "The Lost City of Amdapor (Hard)", 1, 180 },
                    { 65, 71, "Holminster Switch", 1, 370 },
                    { 66, 73, "Dohn Mheg", 1, 375 },
                    { 67, 75, "The Qitana Ravel", 1, 380 },
                    { 68, 77, "Malikah's Well", 1, 385 },
                    { 69, 79, "Mt. Gulg", 1, 390 },
                    { 42, 60, "The Antitower", 1, 180 },
                    { 71, 80, "The Twinning", 1, 410 },
                    { 72, 80, "Akadaemia Anyder", 1, 410 },
                    { 73, 80, "The Grand Cosmos", 1, 430 },
                    { 74, 20, "The Bowl of Embers", 3, 0 },
                    { 75, 34, "The Navel", 3, 0 },
                    { 76, 44, "The Howling Eye", 3, 0 },
                    { 77, 49, "Cape Westwind", 3, 0 },
                    { 79, 50, "The Steps of Faith", 3, 90 },
                    { 80, 50, "A Relic Reborn: The Chimera", 3, 52 },
                    { 81, 50, "A Relic Reborn: The Hydra", 3, 52 },
                    { 82, 50, "Battle on the Big Bridge", 3, 50 },
                    { 64, 70, "The Ghimlyt Dark", 1, 360 },
                    { 63, 70, "The Burn", 1, 340 },
                    { 70, 80, "Amaurot", 1, 410 },
                    { 61, 70, "The Swallow's Compass", 1, 330 },
                    { 44, 60, "Sohr Khai", 1, 200 },
                    { 45, 60, "Hullbreaker Isle (Hard)", 1, 200 },
                    { 62, 70, "Saint Mocianne's Arboretum (Hard)", 1, 340 },
                    { 47, 60, "The Great Gubal Library (Hard)", 1, 210 },
                    { 48, 60, "Baelsar's Wall", 1, 230 },
                    { 49, 60, "Sohm Al (Hard)", 1, 230 },
                    { 50, 61, "The Sirensong Sea", 1, 240 },
                    { 51, 63, "Shisui of the Violet Tides", 1, 245 },
                    { 46, 60, "Xelphatol", 1, 210 },
                    { 53, 67, "Doma Castle", 1, 255 },
                    { 54, 69, "Castrum Abania", 1, 260 },
                    { 55, 70, "Ala Mhigo", 1, 280 },
                    { 56, 70, "Kugane Castle", 1, 280 },
                    { 57, 70, "The Temple of the Fist", 1, 280 },
                    { 58, 70, "The Drowned City of Skalla", 1, 300 },
                    { 59, 70, "Hells' Lid", 1, 310 },
                    { 60, 70, "The Fractal Continuum (Hard)", 1, 310 },
                    { 52, 65, "Bardam's Mettle", 1, 250 }
                });

            migrationBuilder.InsertData(
                table: "PvEContentType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Alliance Raid" },
                    { 3, "Trial" },
                    { 1, "Dungeon" },
                    { 2, "Raid" }
                });

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 10, "Hingashi" },
                    { 1, "La Noscea" },
                    { 2, "The Black Shroud" },
                    { 3, "Thanalan" },
                    { 4, "Mor Dhona" },
                    { 5, "Coerthas" },
                    { 6, "Abalathia's Spine" },
                    { 7, "Dravania" },
                    { 8, "Gyr Abania" },
                    { 9, "Othard" },
                    { 11, "Norvrandt" }
                });

            migrationBuilder.InsertData(
                table: "Zone",
                columns: new[] { "Id", "Name", "RegionId" },
                values: new object[,]
                {
                    { 1, "Limsa Lominsa Upper Decks", 1 },
                    { 30, "Coerthas Western Highlands", 5 },
                    { 31, "The Sea of Clouds", 6 },
                    { 32, "Azys Lla", 6 },
                    { 33, "Idyllshire", 7 },
                    { 34, "Dravanian Forelands", 7 },
                    { 35, "Dravanian Hinterlands", 7 },
                    { 36, "The Churning Mists", 7 },
                    { 37, "Rhalgr's Reach", 8 },
                    { 38, "The Fringes", 8 },
                    { 39, "The Lochs", 8 },
                    { 40, "The Peaks", 8 },
                    { 29, "Coerthas Central Highlands", 5 },
                    { 41, "The Azim Steppe", 9 },
                    { 43, "Yanxia", 9 },
                    { 44, "Kugane", 10 },
                    { 45, "Shirogane", 10 },
                    { 46, "The Crystarium", 11 },
                    { 47, "Eulmore - The Canopy", 11 },
                    { 48, "Eulmore - The Understory", 11 },
                    { 49, "Eulmore - The Buttress", 11 },
                    { 50, "Lakeland", 11 },
                    { 51, "Kholusia", 11 },
                    { 52, "Amh Araeng", 11 },
                    { 53, "Il Mheg", 11 },
                    { 42, "The Ruby Sea", 9 },
                    { 54, "The Rak'tika Greatwood", 11 },
                    { 28, "The Pillars", 5 },
                    { 26, "Mor Dhona", 4 },
                    { 2, "Limsa Lominsa Lower Decks", 1 },
                    { 3, "Lower La Noscea", 1 },
                    { 4, "Middle La Noscea", 1 },
                    { 5, "Eastern la Noscea", 1 },
                    { 6, "Western la Noscea", 1 },
                    { 7, "Outer La Noscea", 1 },
                    { 8, "Upper La Noscea", 1 },
                    { 9, "The Mist", 1 },
                    { 10, "Wolves' Den Pier", 1 },
                    { 19, "Old Gridania", 2 },
                    { 20, "New Gridania", 2 },
                    { 27, "Foundation", 5 },
                    { 21, "Central Shroud", 2 },
                    { 23, "East Shroud", 2 },
                    { 24, "South Shroud", 2 },
                    { 25, "Lavender Beds", 2 },
                    { 11, "Ul'dah - Steps of Nald", 3 },
                    { 12, "Ul'dah - Steps of Thal", 3 },
                    { 13, "Central Thanalan", 3 },
                    { 14, "Western Thanalan", 3 },
                    { 15, "Eastern Thanalan", 3 },
                    { 16, "Southern Thanalan", 3 },
                    { 17, "Northern Thanalan", 3 },
                    { 18, "The Goblet", 3 },
                    { 22, "North Shroud", 2 },
                    { 55, "The Tempest", 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Location_ZoneId",
                table: "Location",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Zone_RegionId",
                table: "Zone",
                column: "RegionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discipline");

            migrationBuilder.DropTable(
                name: "Expansion");

            migrationBuilder.DropTable(
                name: "LeveType");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "PvEContent");

            migrationBuilder.DropTable(
                name: "PvEContentType");

            migrationBuilder.DropTable(
                name: "SightseeingEmote");

            migrationBuilder.DropTable(
                name: "Weather");

            migrationBuilder.DropTable(
                name: "Zone");

            migrationBuilder.DropTable(
                name: "Region");
        }
    }
}
