using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleShop.ProductManagement.Models.Migrations
{
    public partial class UpdateFKRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductSubCatecoryId",
                table: "Product",
                column: "ProductSubCatecoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_SubCategory_ProductSubCatecoryId",
                table: "Product",
                column: "ProductSubCatecoryId",
                principalTable: "SubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_SubCategory_ProductSubCatecoryId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductSubCatecoryId",
                table: "Product");
        }
    }
}
