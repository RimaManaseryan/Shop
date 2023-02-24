using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerName = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    Phone = table.Column<string>(type: "NVARCHAR(12)", nullable: true),
                    Address1 = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    Address2 = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    Status = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    CreditLimit = table.Column<string>(type: "NVARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerName);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ItemCode = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    ItemType = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ItemCode);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrders",
                columns: table => new
                {
                    OrderNbr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    Date = table.Column<DateTime>(type: "DATE", nullable: false),
                    Address = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    ItemCode = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    Description = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    Quantitiy = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrders", x => x.OrderNbr);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SalesOrders");
        }
    }
}
