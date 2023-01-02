using Microsoft.EntityFrameworkCore.Migrations;

namespace McLaren_Cardealer.Migrations
{
    public partial class AddBericht : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropIndex(
                name: "IX_Facturen_KlantId",
                table: "Facturen");

            migrationBuilder.DropColumn(
                name: "KlantId",
                table: "Facturen");

            migrationBuilder.CreateTable(
                name: "Berichten",
                columns: table => new
                {
                    BerichtId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GebruikersNaam = table.Column<string>(nullable: true),
                    Message = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Berichten", x => x.BerichtId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Berichten");

            migrationBuilder.AddColumn<int>(
                name: "KlantId",
                table: "Facturen",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Klanten",
                columns: table => new
                {
                    KlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gemeente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Naam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Rekeningnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klanten", x => x.KlantId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facturen_KlantId",
                table: "Facturen",
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
