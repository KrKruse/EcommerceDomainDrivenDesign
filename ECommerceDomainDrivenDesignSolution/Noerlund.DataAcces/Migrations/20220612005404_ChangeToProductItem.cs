using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Noerlund.DataAcces.Migrations
{
    public partial class ChangeToProductItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemDtosType_OrderDtos_OrderId",
                table: "OrderItemDtosType");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDtos_OrderItemDtosType_OrderItemDtoOrderItemId",
                table: "ProductDtos");

            migrationBuilder.DropIndex(
                name: "IX_ProductDtos_OrderItemDtoOrderItemId",
                table: "ProductDtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItemDtosType",
                table: "OrderItemDtosType");

            migrationBuilder.DropColumn(
                name: "OrderItemDtoOrderItemId",
                table: "ProductDtos");

            migrationBuilder.RenameTable(
                name: "OrderItemDtosType",
                newName: "OrderItemDtos");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItemDtosType_OrderId",
                table: "OrderItemDtos",
                newName: "IX_OrderItemDtos_OrderId");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "OrderItemDtos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItemDtos",
                table: "OrderItemDtos",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDtos_ProductId",
                table: "OrderItemDtos",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemDtos_OrderDtos_OrderId",
                table: "OrderItemDtos",
                column: "OrderId",
                principalTable: "OrderDtos",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemDtos_ProductDtos_ProductId",
                table: "OrderItemDtos",
                column: "ProductId",
                principalTable: "ProductDtos",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemDtos_OrderDtos_OrderId",
                table: "OrderItemDtos");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemDtos_ProductDtos_ProductId",
                table: "OrderItemDtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItemDtos",
                table: "OrderItemDtos");

            migrationBuilder.DropIndex(
                name: "IX_OrderItemDtos_ProductId",
                table: "OrderItemDtos");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderItemDtos");

            migrationBuilder.RenameTable(
                name: "OrderItemDtos",
                newName: "OrderItemDtosType");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItemDtos_OrderId",
                table: "OrderItemDtosType",
                newName: "IX_OrderItemDtosType_OrderId");

            migrationBuilder.AddColumn<Guid>(
                name: "OrderItemDtoOrderItemId",
                table: "ProductDtos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItemDtosType",
                table: "OrderItemDtosType",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDtos_OrderItemDtoOrderItemId",
                table: "ProductDtos",
                column: "OrderItemDtoOrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemDtosType_OrderDtos_OrderId",
                table: "OrderItemDtosType",
                column: "OrderId",
                principalTable: "OrderDtos",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDtos_OrderItemDtosType_OrderItemDtoOrderItemId",
                table: "ProductDtos",
                column: "OrderItemDtoOrderItemId",
                principalTable: "OrderItemDtosType",
                principalColumn: "OrderItemId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
