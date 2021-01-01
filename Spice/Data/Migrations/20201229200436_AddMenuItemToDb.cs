using Microsoft.EntityFrameworkCore.Migrations;

namespace Spice.Data.Migrations
{
    public partial class AddMenuItemToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Spicyness",
                table: "MenuItem");

            migrationBuilder.AddColumn<string>(
                name: "Spicyness",
                table: "MenuItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Spicyness",
                table: "MenuItem");

            migrationBuilder.AddColumn<string>(
                name: "Spicyness",
                table: "MenuItem",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
