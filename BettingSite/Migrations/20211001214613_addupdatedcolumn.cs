using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingSite.Migrations
{
    public partial class addupdatedcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Bets",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Bets");
        }
    }
}
