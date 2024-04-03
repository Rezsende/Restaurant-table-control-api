using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restauranttablecontrolapi.Migrations
{
    /// <inheritdoc />
    public partial class _04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "productDatails");

            migrationBuilder.DropColumn(
                name: "Sale_Price",
                table: "productDatails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Barcode",
                table: "productDatails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Sale_Price",
                table: "productDatails",
                type: "float",
                nullable: true);
        }
    }
}
