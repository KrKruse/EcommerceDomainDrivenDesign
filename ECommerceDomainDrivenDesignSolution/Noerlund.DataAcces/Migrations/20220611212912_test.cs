using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Noerlund.DataAcces.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDtos_CategoryDtos_CategoryId",
                table: "ProductDtos");

            migrationBuilder.DropIndex(
                name: "IX_ProductDtos_CategoryId",
                table: "ProductDtos");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryDtoCategoryId",
                table: "ProductDtos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductDtos_CategoryDtoCategoryId",
                table: "ProductDtos",
                column: "CategoryDtoCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDtos_CategoryDtos_CategoryDtoCategoryId",
                table: "ProductDtos",
                column: "CategoryDtoCategoryId",
                principalTable: "CategoryDtos",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDtos_CategoryDtos_CategoryDtoCategoryId",
                table: "ProductDtos");

            migrationBuilder.DropIndex(
                name: "IX_ProductDtos_CategoryDtoCategoryId",
                table: "ProductDtos");

            migrationBuilder.DropColumn(
                name: "CategoryDtoCategoryId",
                table: "ProductDtos");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDtos_CategoryId",
                table: "ProductDtos",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDtos_CategoryDtos_CategoryId",
                table: "ProductDtos",
                column: "CategoryId",
                principalTable: "CategoryDtos",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
