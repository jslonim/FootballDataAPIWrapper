using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballDataWrapper.Data.Migrations
{
    public partial class AddSpecificId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Team",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Player",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompetitionId",
                table: "Competition",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "CompetitionId",
                table: "Competition");
        }
    }
}
