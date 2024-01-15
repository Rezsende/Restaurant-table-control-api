using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restauranttablecontrolapi.Migrations
{
    /// <inheritdoc />
    public partial class table04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Entity_ProductDetails_Entity_productDetailId",
                table: "Product_Entity");

            migrationBuilder.DropIndex(
                name: "IX_Product_Entity_productDetailId",
                table: "Product_Entity");

            migrationBuilder.DropColumn(
                name: "productDetailId",
                table: "Product_Entity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
