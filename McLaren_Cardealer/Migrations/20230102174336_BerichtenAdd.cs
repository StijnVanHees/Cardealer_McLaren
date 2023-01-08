using Microsoft.EntityFrameworkCore.Migrations;

namespace McLaren_Cardealer.Migrations
{
    public partial class BerichtenAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        }
    }
}
