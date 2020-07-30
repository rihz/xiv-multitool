using Microsoft.EntityFrameworkCore.Migrations;

namespace XIVChecklist.Data.Migrations
{
    public partial class MSQDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MSQTask",
                table: "MSQTask");

            migrationBuilder.RenameTable(
                name: "MSQTask",
                newName: "MSQTasks");

            migrationBuilder.RenameIndex(
                name: "IX_MSQTask_MSQTypeId",
                table: "MSQTasks",
                newName: "IX_MSQTasks_MSQTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MSQTask_CategoryId",
                table: "MSQTasks",
                newName: "IX_MSQTasks_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MSQTasks",
                table: "MSQTasks",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MSQTasks",
                table: "MSQTasks");

            migrationBuilder.RenameTable(
                name: "MSQTasks",
                newName: "MSQTask");

            migrationBuilder.RenameIndex(
                name: "IX_MSQTasks_MSQTypeId",
                table: "MSQTask",
                newName: "IX_MSQTask_MSQTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MSQTasks_CategoryId",
                table: "MSQTask",
                newName: "IX_MSQTask_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MSQTask",
                table: "MSQTask",
                column: "Id");
        }
    }
}
