using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restauranttablecontrolapi.Migrations
{
    /// <inheritdoc />
    public partial class table03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Entity_Product_Entity_productId",
                table: "ProductDetails_Entity");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_Entity_productId",
                table: "ProductDetails_Entity");

            migrationBuilder.DropColumn(
                name: "productId",
                table: "ProductDetails_Entity");

            migrationBuilder.AddColumn<string>(
                name: "Barcode",
                table: "ProductDetails_Entity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProductDetails_Entity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Sale_Price",
                table: "ProductDetails_Entity",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "productDetailId",
                table: "Product_Entity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_Entity_productDetailId",
                table: "Product_Entity",
                column: "productDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Entity_ProductDetails_Entity_productDetailId",
                table: "Product_Entity",
                column: "productDetailId",
                principalTable: "ProductDetails_Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Entity_ProductDetails_Entity_productDetailId",
                table: "Product_Entity");

            migrationBuilder.DropIndex(
                name: "IX_Product_Entity_productDetailId",
                table: "Product_Entity");

            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "ProductDetails_Entity");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProductDetails_Entity");

            migrationBuilder.DropColumn(
                name: "Sale_Price",
                table: "ProductDetails_Entity");

            migrationBuilder.DropColumn(
                name: "productDetailId",
                table: "Product_Entity");

            migrationBuilder.AddColumn<int>(
                name: "productId",
                table: "ProductDetails_Entity",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_Entity_productId",
                table: "ProductDetails_Entity",
                column: "productId",
                unique: true,
                filter: "[productId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Entity_Product_Entity_productId",
                table: "ProductDetails_Entity",
                column: "productId",
                principalTable: "Product_Entity",
                principalColumn: "Id");
        }
    }
}
