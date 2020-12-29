using Microsoft.EntityFrameworkCore.Migrations;

namespace Spice.Data.Migrations
{
    public partial class AddForeignKeyToCategory_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategory_Category_categoryId",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "SubCategory");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "SubCategory",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategory_categoryId",
                table: "SubCategory",
                newName: "IX_SubCategory_CategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "SubCategory",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategory_Category_CategoryId",
                table: "SubCategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategory_Category_CategoryId",
                table: "SubCategory");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "SubCategory",
                newName: "categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategory",
                newName: "IX_SubCategory_categoryId");

            migrationBuilder.AlterColumn<int>(
                name: "categoryId",
                table: "SubCategory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "SubCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategory_Category_categoryId",
                table: "SubCategory",
                column: "categoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
