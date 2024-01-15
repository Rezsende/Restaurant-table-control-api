using System;
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
            migrationBuilder.AddColumn<DateTime>(
                name: "DataSales",
                table: "ProductDetails_Entity",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Qtd",
                table: "ProductDetails_Entity",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataSales",
                table: "ProductDetails_Entity");

            migrationBuilder.DropColumn(
                name: "Qtd",
                table: "ProductDetails_Entity");
        }
    }
}
