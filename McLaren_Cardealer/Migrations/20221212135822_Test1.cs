using Microsoft.EntityFrameworkCore.Migrations;

namespace McLaren_Cardealer.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturen_Klanten_KlantId",
                table: "Facturen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Klanten",
                table: "Klanten");

            migrationBuilder.RenameTable(
                name: "Klanten",
                newName: "Klant");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Klant",
                table: "Klant",
                column: "KlantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturen_Klant_KlantId",
                table: "Facturen",
                column: "KlantId",
                principalTable: "Klant",
                principalColumn: "KlantId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturen_Klant_KlantId",
                table: "Facturen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Klant",
                table: "Klant");

            migrationBuilder.RenameTable(
                name: "Klant",
                newName: "Klanten");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Klanten",
                table: "Klanten",
                column: "KlantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturen_Klanten_KlantId",
                table: "Facturen",
                column: "KlantId",
                principalTable: "Klanten",
                principalColumn: "KlantId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
