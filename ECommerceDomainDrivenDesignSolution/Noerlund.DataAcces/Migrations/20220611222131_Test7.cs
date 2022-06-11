using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Noerlund.DataAcces.Migrations
{
    public partial class Test7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "ProductDtos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "ProductDtos",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
