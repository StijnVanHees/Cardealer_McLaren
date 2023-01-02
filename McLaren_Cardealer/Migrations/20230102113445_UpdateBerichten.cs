using Microsoft.EntityFrameworkCore.Migrations;

namespace McLaren_Cardealer.Migrations
{
    public partial class UpdateBerichten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GebruikersNaam",
                table: "Berichten");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Berichten",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Berichten");

            migrationBuilder.AddColumn<string>(
                name: "GebruikersNaam",
                table: "Berichten",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
