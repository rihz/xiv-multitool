using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XIVChecklist.Data.Migrations
{
    public partial class RelicWeaponTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 242,
                column: "ParentCategoryId",
                value: 241);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 243,
                column: "ParentCategoryId",
                value: 241);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.CreateTable(
                name: "RelicWeaponTasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DisciplineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelicWeaponTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_RelicWeaponTasks",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Discipline_RelicWeaponTasks",
                        column: x => x.DisciplineId,
                        principalTable: "Discipline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentCategoryId", "Position" },
                values: new object[] { 245, "Relic Weapons", 79, 2 });

            migrationBuilder.InsertData(
                table: "RelicWeaponTasks",
                columns: new[] { "Id", "CategoryId", "DisciplineId", "Name" },
                values: new object[,]
                {
                    { 56, 29, 6, "Tetrabiblos" },
                    { 55, 29, 6, "Elements" },
                    { 54, 29, 11, "Mimesis" },
                    { 53, 29, 11, "Book of the Mad Queen" },
                    { 52, 29, 11, "Draconomicon" },
                    { 51, 29, 11, "Almandal" },
                    { 50, 29, 9, "Kaladanda" },
                    { 49, 29, 9, "Rod of the Black Khan" },
                    { 48, 29, 9, "Hvergelmir" },
                    { 47, 29, 9, "Lunaris Rod" },
                    { 46, 29, 16, "Terpander" },
                    { 45, 29, 16, "Bow of the Autarch" },
                    { 44, 29, 16, "Gandiva" },
                    { 43, 29, 16, "Berimbau" },
                    { 42, 29, 15, "Areadbhar" },
                    { 41, 29, 15, "Trident of the Overlord" },
                    { 57, 29, 6, "Word of the Magnate" },
                    { 58, 29, 6, "Anabasis" },
                    { 59, 29, 5, "Seraph Cane" },
                    { 60, 29, 5, "Majestas" },
                    { 76, 29, 3, "Nothung" },
                    { 75, 29, 3, "Deathbringer" },
                    { 74, 29, 7, "Canopus" },
                    { 73, 29, 7, "Sphere of the Last Heir" },
                    { 72, 29, 7, "Deneb" },
                    { 71, 29, 7, "Atlas" },
                    { 70, 29, 27, "Deathlocke" },
                    { 40, 29, 15, "Rhongomiant" },
                    { 69, 29, 27, "Flame of the Dynast" },
                    { 67, 29, 27, "Ferdinand" },
                    { 66, 29, 14, "Sandung" },
                    { 65, 29, 14, "Spurs of the Thorn Prince" },
                    { 64, 29, 14, "Kannagi" },
                    { 63, 29, 14, "Yukimitsu" },
                    { 62, 29, 5, "Sindri" },
                    { 61, 29, 5, "Cane of the White Tsar" },
                    { 68, 29, 27, "Armageddon" },
                    { 39, 29, 15, "Brionac" },
                    { 38, 29, 1, "Minos" },
                    { 37, 29, 1, "Axe of the Blood Emperor" },
                    { 16, 28, 11, "Apocalypse" },
                    { 15, 28, 11, "The Veil of Wiyu" },
                    { 14, 28, 9, "Lilith Rod" },
                    { 13, 28, 9, "Stardust Rod" },
                    { 12, 28, 16, "Yoichi Bow" },
                    { 11, 28, 16, "Artemis Bow" },
                    { 10, 28, 15, "Longinus" },
                    { 17, 28, 6, "Omnilex" },
                    { 9, 28, 15, "Gae Bolg" },
                    { 7, 28, 1, "Bravura" },
                    { 6, 28, 12, "Kaiser Knuckles" },
                    { 5, 28, 12, "Sphairai" },
                    { 4, 28, 2, "Aegis Shield" },
                    { 3, 28, 2, "Holy Shield" },
                    { 2, 28, 2, "Excalibur" },
                    { 1, 28, 2, "Curtana" },
                    { 8, 28, 1, "Ragnarok" },
                    { 77, 29, 3, "Guillotine of the Tyrant" },
                    { 18, 28, 6, "Last Resort" },
                    { 20, 28, 5, "Nirvana" },
                    { 36, 29, 1, "Ukonvasara" },
                    { 35, 29, 1, "Parashu" },
                    { 34, 29, 12, "Nyepel" },
                    { 33, 29, 12, "Sultan's Fist" },
                    { 32, 29, 12, "Verethragna" },
                    { 31, 29, 12, "Rising Suns" },
                    { 30, 29, 2, "Priwen" },
                    { 19, 28, 5, "Thyrus" },
                    { 29, 29, 2, "Shield of the Twin Thegns" },
                    { 27, 29, 2, "Prytwen" },
                    { 26, 29, 2, "Aettir" },
                    { 25, 29, 2, "Sword of the Twin Thegns" },
                    { 24, 29, 2, "Almace" },
                    { 23, 29, 2, "Hauteclaire" },
                    { 22, 28, 14, "Sasuke's Blades" },
                    { 21, 28, 14, "Yoshimitsu" },
                    { 28, 29, 2, "Ancile" },
                    { 78, 29, 3, "Cronus" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentCategoryId", "Position" },
                values: new object[] { 246, "Zodiac", 245, 3 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentCategoryId", "Position" },
                values: new object[] { 247, "Anima", 245, 3 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentCategoryId", "Position" },
                values: new object[] { 248, "Eurekan", 245, 3 });

            migrationBuilder.InsertData(
                table: "RelicWeaponTasks",
                columns: new[] { "Id", "CategoryId", "DisciplineId", "Name" },
                values: new object[,]
                {
                    { 79, 248, 2, "Galatyn" },
                    { 105, 248, 9, "Paikea" },
                    { 106, 248, 11, "Lemegeton" },
                    { 107, 248, 11, "Elemental Grimoire" },
                    { 108, 248, 11, "Tuah" },
                    { 109, 248, 8, "Murgleis" },
                    { 110, 248, 8, "Elemental Tuck" },
                    { 111, 248, 8, "Brunello" },
                    { 112, 248, 16, "Failnaught" },
                    { 113, 248, 16, "Elemental Harp Bow" },
                    { 104, 248, 9, "Elemental Rod" },
                    { 114, 248, 16, "Circinae" },
                    { 116, 248, 27, "Elemental Handgonne" },
                    { 117, 248, 27, "Mollfrith" },
                    { 118, 248, 5, "Aymur" },
                    { 119, 248, 5, "Elemental Cane" },
                    { 120, 248, 5, "Rose Couverte" },
                    { 121, 248, 6, "Organum" },
                    { 122, 248, 6, "Elemental Codex" },
                    { 123, 248, 6, "Jebat" },
                    { 124, 248, 7, "Pleiades" },
                    { 115, 248, 27, "Outsider" },
                    { 103, 248, 9, "Vanargand" },
                    { 102, 248, 13, "Torigashira" },
                    { 101, 248, 13, "Elemental Blade" },
                    { 80, 248, 2, "Elemental Sword" },
                    { 81, 248, 2, "Antea" },
                    { 82, 248, 2, "Evalach" },
                    { 83, 248, 2, "Elemental Shield" },
                    { 84, 248, 2, "Bellerophon" },
                    { 85, 248, 1, "Farsha" },
                    { 86, 248, 1, "Elemental Battleaxe" },
                    { 87, 248, 1, "Shamash" },
                    { 88, 248, 3, "Caladbolg" },
                    { 89, 248, 3, "Elemental Guillotine" },
                    { 90, 248, 3, "Xiphias" },
                    { 91, 248, 15, "Ryunohige" },
                    { 92, 248, 15, "Elemental Lance" },
                    { 93, 248, 15, "Daboya" },
                    { 94, 248, 12, "Sudarshana Chakra" },
                    { 95, 248, 12, "Elemental Knuckles" },
                    { 96, 248, 12, "Dumuzis" },
                    { 97, 248, 14, "Nagi" },
                    { 98, 248, 14, "Elemental Knives" },
                    { 99, 248, 14, "Kasasagi" },
                    { 100, 248, 13, "Kiku-ichimonji" },
                    { 125, 248, 7, "Elemental Astrometer" },
                    { 126, 248, 7, "Albireo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RelicWeaponTasks_CategoryId",
                table: "RelicWeaponTasks",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RelicWeaponTasks_DisciplineId",
                table: "RelicWeaponTasks",
                column: "DisciplineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelicWeaponTasks");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentCategoryId", "Position" },
                values: new object[] { 226, "Weapon Quests", 140, 2 });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 242,
                column: "ParentCategoryId",
                value: 226);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 243,
                column: "ParentCategoryId",
                value: 226);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentCategoryId", "Position" },
                values: new object[,]
                {
                    { 227, "General", 226, 3 },
                    { 228, "Astrologian", 226, 3 },
                    { 229, "Black Mage", 226, 3 },
                    { 230, "Bard", 226, 3 },
                    { 231, "Dark Knight", 226, 3 },
                    { 232, "Dragoon", 226, 3 },
                    { 233, "Machinist", 226, 3 },
                    { 234, "Monk", 226, 3 },
                    { 235, "Ninja", 226, 3 },
                    { 236, "Paladin", 226, 3 },
                    { 237, "Scholar", 226, 3 },
                    { 238, "Summoner", 226, 3 },
                    { 239, "Warrior", 226, 3 },
                    { 240, "White Mage", 226, 3 }
                });
        }
    }
}
