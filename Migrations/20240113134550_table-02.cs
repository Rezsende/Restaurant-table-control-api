using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restauranttablecontrolapi.Migrations
{
    /// <inheritdoc />
    public partial class table02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Product_Entity",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Commands_Entity",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "commandId",
                table: "Product_Entity",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_Entity_commandId",
                table: "Product_Entity",
                column: "commandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Entity_Commands_Entity_commandId",
                table: "Product_Entity",
                column: "commandId",
                principalTable: "Commands_Entity",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Entity_Commands_Entity_commandId",
                table: "Product_Entity");

            migrationBuilder.DropIndex(
                name: "IX_Product_Entity_commandId",
                table: "Product_Entity");

            migrationBuilder.DropColumn(
                name: "commandId",
                table: "Product_Entity");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Product_Entity",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Commands_Entity",
                newName: "Desc");
        }
    }
}
