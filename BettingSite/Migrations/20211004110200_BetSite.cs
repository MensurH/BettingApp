using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingSite.Migrations
{
    public partial class BetSite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Teams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Quotes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Matches",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Matches");
        }
    }
}
