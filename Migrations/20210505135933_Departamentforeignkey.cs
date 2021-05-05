using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMVC.Migrations
{
    public partial class Departamentforeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sellers_Departaments_departamentsId",
                table: "sellers");

            migrationBuilder.RenameColumn(
                name: "departamentsId",
                table: "sellers",
                newName: "DepartamentsId");

            migrationBuilder.RenameIndex(
                name: "IX_sellers_departamentsId",
                table: "sellers",
                newName: "IX_sellers_DepartamentsId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartamentsId",
                table: "sellers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_sellers_Departaments_DepartamentsId",
                table: "sellers",
                column: "DepartamentsId",
                principalTable: "Departaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sellers_Departaments_DepartamentsId",
                table: "sellers");

            migrationBuilder.RenameColumn(
                name: "DepartamentsId",
                table: "sellers",
                newName: "departamentsId");

            migrationBuilder.RenameIndex(
                name: "IX_sellers_DepartamentsId",
                table: "sellers",
                newName: "IX_sellers_departamentsId");

            migrationBuilder.AlterColumn<int>(
                name: "departamentsId",
                table: "sellers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_sellers_Departaments_departamentsId",
                table: "sellers",
                column: "departamentsId",
                principalTable: "Departaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
