using Microsoft.EntityFrameworkCore.Migrations;

namespace XIVChecklist.Data.Migrations
{
    public partial class CascadeSheetDelete2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sheet_MarketTransactions",
                table: "MarketTransaction");

            migrationBuilder.AddForeignKey(
                name: "FK_Sheet_MarketTransactions",
                table: "MarketTransaction",
                column: "SheetId",
                principalTable: "LedgerSheet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sheet_MarketTransactions",
                table: "MarketTransaction");

            migrationBuilder.AddForeignKey(
                name: "FK_Sheet_MarketTransactions",
                table: "MarketTransaction",
                column: "SheetId",
                principalTable: "LedgerSheet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
