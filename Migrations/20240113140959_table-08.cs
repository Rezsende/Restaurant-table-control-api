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
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Entity_Commands_Entity_CommandId",
                table: "Product_Entity");

            migrationBuilder.DropIndex(
                name: "IX_Product_Entity_CommandId",
                table: "Product_Entity");

            migrationBuilder.DropColumn(
                name: "CommandId",
                table: "Product_Entity");

            migrationBuilder.AddColumn<int>(
                name: "ProductsID",
                table: "Commands_Entity",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Commands_Entity_ProductsID",
                table: "Commands_Entity",
                column: "ProductsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Entity_Product_Entity_ProductsID",
                table: "Commands_Entity",
                column: "ProductsID",
                principalTable: "Product_Entity",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Entity_Product_Entity_ProductsID",
                table: "Commands_Entity");

            migrationBuilder.DropIndex(
                name: "IX_Commands_Entity_ProductsID",
                table: "Commands_Entity");

            migrationBuilder.DropColumn(
                name: "ProductsID",
                table: "Commands_Entity");

            migrationBuilder.AddColumn<int>(
                name: "CommandId",
                table: "Product_Entity",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_Entity_CommandId",
                table: "Product_Entity",
                column: "CommandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Entity_Commands_Entity_CommandId",
                table: "Product_Entity",
                column: "CommandId",
                principalTable: "Commands_Entity",
                principalColumn: "Id");
        }
    }
}
