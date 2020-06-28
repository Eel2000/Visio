using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Visio_Beta.Data.Migrations
{
    public partial class changeBytInBytArray : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Content",
                table: "Books",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Content",
                table: "Books",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte[]));
        }
    }
}
