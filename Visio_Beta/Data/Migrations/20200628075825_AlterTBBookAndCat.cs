using Microsoft.EntityFrameworkCore.Migrations;

namespace Visio_Beta.Data.Migrations
{
    public partial class AlterTBBookAndCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Books_BookId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_BookId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoriesId",
                table: "Books",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoriesId",
                table: "Books",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoriesId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategoriesId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_BookId",
                table: "Categories",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Books_BookId",
                table: "Categories",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
