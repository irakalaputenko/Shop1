using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    street = table.Column<string>(nullable: true),
                    numberstreet = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    code = table.Column<int>(nullable: false),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    orderTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDeteil",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    orderId = table.Column<int>(nullable: false),
                    vegetablesId = table.Column<int>(nullable: false),
                    price = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDeteil", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderDeteil_Order_orderId",
                        column: x => x.orderId,
                        principalTable: "Order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDeteil_Vegetables_vegetablesId",
                        column: x => x.vegetablesId,
                        principalTable: "Vegetables",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDeteil_orderId",
                table: "OrderDeteil",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDeteil_vegetablesId",
                table: "OrderDeteil",
                column: "vegetablesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDeteil");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
