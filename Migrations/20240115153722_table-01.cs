using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restauranttablecontrolapi.Migrations
{
    /// <inheritdoc />
    public partial class table01 : Migration
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
                name: "Commands_Entity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commands_Entity", x => x.Id);
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
                name: "ProductDetails_Entity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productId = table.Column<int>(type: "int", nullable: true),
                    commandId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails_Entity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Entity_Commands_Entity_commandId",
                        column: x => x.commandId,
                        principalTable: "Commands_Entity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductDetails_Entity_Product_Entity_productId",
                        column: x => x.productId,
                        principalTable: "Product_Entity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_Entity_commandId",
                table: "ProductDetails_Entity",
                column: "commandId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_Entity_productId",
                table: "ProductDetails_Entity",
                column: "productId",
                unique: true,
                filter: "[productId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients_Entity");

            migrationBuilder.DropTable(
                name: "ProductDetails_Entity");

            migrationBuilder.DropTable(
                name: "Commands_Entity");

            migrationBuilder.DropTable(
                name: "Product_Entity");
        }
    }
}
