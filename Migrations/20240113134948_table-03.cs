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
                name: "FK_Product_Entity_Commands_Entity_commandId",
                table: "Product_Entity");

            migrationBuilder.AlterColumn<int>(
                name: "commandId",
                table: "Product_Entity",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Entity_Commands_Entity_commandId",
                table: "Product_Entity",
                column: "commandId",
                principalTable: "Commands_Entity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Entity_Commands_Entity_commandId",
                table: "Product_Entity");

            migrationBuilder.AlterColumn<int>(
                name: "commandId",
                table: "Product_Entity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Entity_Commands_Entity_commandId",
                table: "Product_Entity",
                column: "commandId",
                principalTable: "Commands_Entity",
                principalColumn: "Id");
        }
    }
}
