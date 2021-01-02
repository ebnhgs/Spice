using Microsoft.EntityFrameworkCore.Migrations;

namespace Spice.Data.Migrations
{
    public partial class CorrectCouponIsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActiveFlag",
                table: "Coupon");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Coupon",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Coupon");

            migrationBuilder.AddColumn<bool>(
                name: "IsActiveFlag",
                table: "Coupon",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
