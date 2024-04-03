using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restauranttablecontrolapi.Migrations
{
    /// <inheritdoc />
    public partial class _01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients_Entity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Road = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complement = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients_Entity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product_Entity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchasePrice = table.Column<double>(name: "Purchase_Price", type: "float", nullable: true),
                    SalePrice = table.Column<double>(name: "Sale_Price", type: "float", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: true),
                    ExpirationDate = table.Column<DateTime>(name: "Expiration_Date", type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Entity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Commands_Entity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    restaurantTableId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commands_Entity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commands_Entity_RestaurantTable_restaurantTableId",
                        column: x => x.restaurantTableId,
                        principalTable: "RestaurantTable",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "productDatails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    commandId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productDatails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productDatails_Commands_Entity_commandId",
                        column: x => x.commandId,
                        principalTable: "Commands_Entity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commands_Entity_restaurantTableId",
                table: "Commands_Entity",
                column: "restaurantTableId");

            migrationBuilder.CreateIndex(
                name: "IX_productDatails_commandId",
                table: "productDatails",
                column: "commandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients_Entity");

            migrationBuilder.DropTable(
                name: "Product_Entity");

            migrationBuilder.DropTable(
                name: "productDatails");

            migrationBuilder.DropTable(
                name: "Commands_Entity");

            migrationBuilder.DropTable(
                name: "RestaurantTable");
        }
    }
}
