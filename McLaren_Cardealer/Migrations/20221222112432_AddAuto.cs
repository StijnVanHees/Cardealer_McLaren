using Microsoft.EntityFrameworkCore.Migrations;

namespace McLaren_Cardealer.Migrations
{
    public partial class AddAuto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autos",
                columns: table => new
                {
                    AutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(maxLength: 50, nullable: false),
                    Prijs = table.Column<int>(nullable: false),
                    Kilogram = table.Column<string>(nullable: false),
                    Kleur = table.Column<string>(nullable: false),
                    Foto = table.Column<string>(nullable: true),
                    WielenId = table.Column<int>(nullable: false)
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
