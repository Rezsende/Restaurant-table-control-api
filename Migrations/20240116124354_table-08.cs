using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restauranttablecontrolapi.Migrations
{
    /// <inheritdoc />
    public partial class table08 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductDetails_Entity",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_Entity_ProductId",
                table: "ProductDetails_Entity",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Entity_Product_Entity_ProductId",
                table: "ProductDetails_Entity",
                column: "ProductId",
                principalTable: "Product_Entity",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Entity_Product_Entity_ProductId",
                table: "ProductDetails_Entity");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_Entity_ProductId",
                table: "ProductDetails_Entity");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductDetails_Entity");
        }
    }
}
