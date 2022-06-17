using Microsoft.EntityFrameworkCore.Migrations;

namespace Noerlund.DataAcces.Migrations
{
    public partial class PriceInclude : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pris",
                table: "ProductDtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalPris",
                table: "OrderDtos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pris",
                table: "ProductDtos");

            migrationBuilder.DropColumn(
                name: "TotalPris",
                table: "OrderDtos");
        }
    }
}
