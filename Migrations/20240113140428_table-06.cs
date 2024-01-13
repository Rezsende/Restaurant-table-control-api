using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restauranttablecontrolapi.Migrations
{
    /// <inheritdoc />
    public partial class table06 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Entity_Product_Entity_productsId",
                table: "Commands_Entity");

            migrationBuilder.DropIndex(
                name: "IX_Commands_Entity_productsId",
                table: "Commands_Entity");

            migrationBuilder.RenameColumn(
                name: "productsId",
                table: "Commands_Entity",
                newName: "ProductsId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "Commands_Entity",
                newName: "productsId");

            migrationBuilder.CreateIndex(
                name: "IX_Commands_Entity_productsId",
                table: "Commands_Entity",
                column: "productsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Entity_Product_Entity_productsId",
                table: "Commands_Entity",
                column: "productsId",
                principalTable: "Product_Entity",
                principalColumn: "Id");
        }
    }
}
