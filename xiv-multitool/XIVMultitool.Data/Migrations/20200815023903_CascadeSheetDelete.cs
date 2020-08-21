using Microsoft.EntityFrameworkCore.Migrations;

namespace XIVChecklist.Data.Migrations
{
    public partial class CascadeSheetDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_LedgerSheets",
                table: "LedgerSheet");

            migrationBuilder.AddForeignKey(
                name: "FK_User_LedgerSheets",
                table: "LedgerSheet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_LedgerSheets",
                table: "LedgerSheet");

            migrationBuilder.AddForeignKey(
                name: "FK_User_LedgerSheets",
                table: "LedgerSheet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
