using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restauranttablecontrolapi.Migrations
{
    /// <inheritdoc />
    public partial class table05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "productsId",
                table: "Commands_Entity",
                type: "int",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Entity_Product_Entity_productsId",
                table: "Commands_Entity");

            migrationBuilder.DropIndex(
                name: "IX_Commands_Entity_productsId",
                table: "Commands_Entity");

            migrationBuilder.DropColumn(
                name: "productsId",
                table: "Commands_Entity");
        }
    }
}
