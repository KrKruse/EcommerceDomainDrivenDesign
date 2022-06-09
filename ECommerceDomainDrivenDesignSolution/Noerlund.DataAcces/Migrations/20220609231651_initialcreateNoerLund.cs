using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Noerlund.DataAcces.Migrations
{
    public partial class initialcreateNoerLund : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryDtos",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDtos", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDtos",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDtos", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "OrderDtos",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDtos", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_OrderDtos_CustomerDtos_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerDtos",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItemDtosType",
                columns: table => new
                {
                    OrderItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItemDtosType", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItemDtosType_OrderDtos_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderDtos",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDtos",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderItemDtoOrderItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDtos", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ProductDtos_CategoryDtos_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoryDtos",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDtos_OrderItemDtosType_OrderItemDtoOrderItemId",
                        column: x => x.OrderItemDtoOrderItemId,
                        principalTable: "OrderItemDtosType",
                        principalColumn: "OrderItemId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDtos_CustomerId",
                table: "OrderDtos",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDtosType_OrderId",
                table: "OrderItemDtosType",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDtos_CategoryId",
                table: "ProductDtos",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDtos_OrderItemDtoOrderItemId",
                table: "ProductDtos",
                column: "OrderItemDtoOrderItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDtos");

            migrationBuilder.DropTable(
                name: "CategoryDtos");

            migrationBuilder.DropTable(
                name: "OrderItemDtosType");

            migrationBuilder.DropTable(
                name: "OrderDtos");

            migrationBuilder.DropTable(
                name: "CustomerDtos");
        }
    }
}
