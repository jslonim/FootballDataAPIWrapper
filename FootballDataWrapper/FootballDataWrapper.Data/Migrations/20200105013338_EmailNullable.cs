using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballDataWrapper.Data.Migrations
{
    public partial class EmailNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Team",
                maxLength: 75,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 75);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Team",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 75,
                oldNullable: true);
        }
    }
}
