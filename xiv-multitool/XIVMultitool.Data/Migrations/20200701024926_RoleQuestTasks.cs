using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XIVChecklist.Data.Migrations
{
    public partial class RoleQuestTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoleQuestTasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    JobRoleId = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleQuestTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_RoleQuestTasks",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobRole_RoleQuestTasks",
                        column: x => x.JobRoleId,
                        principalTable: "JobRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentCategoryId", "Position" },
                values: new object[] { 244, "Epilogue", 218, 3 });

            migrationBuilder.UpdateData(
                table: "JobRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Physical DPS");

            migrationBuilder.UpdateData(
                table: "JobRole",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Healer");

            migrationBuilder.UpdateData(
                table: "JobRole",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Magic DPS");

            migrationBuilder.UpdateData(
                table: "JobRole",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Epilogue");

            migrationBuilder.InsertData(
                table: "RoleQuestTasks",
                columns: new[] { "Id", "CategoryId", "JobRoleId", "Level", "Name" },
                values: new object[,]
                {
                    { 23, 218, 4, 78, "Taynor's Training Day" },
                    { 22, 218, 4, 76, "Nyelbert's Lament" },
                    { 21, 218, 4, 74, "Echoes of the Past" },
                    { 20, 218, 4, 72, "A Voice from the Void" },
                    { 19, 218, 4, 70, "Hollow Pursuits" },
                    { 18, 218, 3, 80, "The Soul of Temperence" },
                    { 17, 218, 3, 78, "Never to Return" },
                    { 16, 218, 3, 76, "The Lost and the Found" },
                    { 15, 218, 3, 74, "The Scientific Method" },
                    { 14, 218, 3, 72, "Affronts and Allies" },
                    { 13, 218, 3, 70, "Traditions and Travails" },
                    { 10, 218, 2, 76, "The Hunter's Legacy" },
                    { 11, 218, 2, 78, "Fellowship Restored" },
                    { 24, 218, 4, 80, "A Tearful Reunion" },
                    { 9, 218, 2, 74, "Freedom from Privilege" },
                    { 8, 218, 2, 72, "Vengeance in Defeat" },
                    { 7, 218, 2, 70, "No Greater Sport" },
                    { 6, 218, 1, 80, "To Have Loved and Lost" },
                    { 5, 218, 1, 78, "The Hardened Heart" },
                    { 4, 218, 1, 76, "The Princess and Her Knight" },
                    { 3, 218, 1, 74, "Defined By Loss" },
                    { 2, 218, 1, 72, "Shaped by Tragedy" },
                    { 1, 218, 1, 70, "The Man with Too Many Scars" },
                    { 12, 218, 2, 80, "Courage Born of Fear" },
                    { 25, 218, 5, 80, "Shadow Walk with Me" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleQuestTasks_CategoryId",
                table: "RoleQuestTasks",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleQuestTasks_JobRoleId",
                table: "RoleQuestTasks",
                column: "JobRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleQuestTasks");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.UpdateData(
                table: "JobRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Healer");

            migrationBuilder.UpdateData(
                table: "JobRole",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Physical DPS");

            migrationBuilder.UpdateData(
                table: "JobRole",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Magical DPS");

            migrationBuilder.UpdateData(
                table: "JobRole",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Any");
        }
    }
}
