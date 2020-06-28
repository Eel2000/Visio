using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Visio_Beta.Data.Migrations
{
    public partial class addDateColumnsToBookTb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Add_date",
                table: "Books",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Update_date",
                table: "Books",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Add_date",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Update_date",
                table: "Books");
        }
    }
}
