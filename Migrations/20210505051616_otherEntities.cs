using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMVC.Migrations
{
    public partial class otherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sellers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BaseSalary = table.Column<double>(nullable: false),
                    departamentsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sellers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sellers_Departaments_departamentsId",
                        column: x => x.departamentsId,
                        principalTable: "Departaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sellerRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    sellerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sellerRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sellerRecords_sellers_sellerId",
                        column: x => x.sellerId,
                        principalTable: "sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sellerRecords_sellerId",
                table: "sellerRecords",
                column: "sellerId");

            migrationBuilder.CreateIndex(
                name: "IX_sellers_departamentsId",
                table: "sellers",
                column: "departamentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sellerRecords");

            migrationBuilder.DropTable(
                name: "sellers");
        }
    }
}
