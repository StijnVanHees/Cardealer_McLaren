using Microsoft.EntityFrameworkCore.Migrations;

namespace McLaren_Cardealer.Migrations
{
    public partial class KlantToevoegen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klant",
                columns: table => new
                {
                    KlantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(maxLength: 50, nullable: false),
                    Voornaam = table.Column<string>(nullable: false),
                    Gemeente = table.Column<string>(nullable: true),
                    Rekeningnummer = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klant", x => x.KlantId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
