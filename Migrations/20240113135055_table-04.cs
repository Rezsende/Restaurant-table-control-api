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
                name: "FK_Product_Entity_Commands_Entity_commandId",
                table: "Product_Entity");

            migrationBuilder.DropIndex(
                name: "IX_Product_Entity_commandId",
                table: "Product_Entity");

            migrationBuilder.DropColumn(
                name: "commandId",
                table: "Product_Entity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "commandId",
                table: "Product_Entity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_Entity_commandId",
                table: "Product_Entity",
                column: "commandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Entity_Commands_Entity_commandId",
                table: "Product_Entity",
                column: "commandId",
                principalTable: "Commands_Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
