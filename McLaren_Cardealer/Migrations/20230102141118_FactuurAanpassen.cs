using Microsoft.EntityFrameworkCore.Migrations;

namespace McLaren_Cardealer.Migrations
{
    public partial class FactuurAanpassen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Facturen",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "reservationnumber",
                table: "Facturen",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Facturen");

            migrationBuilder.DropColumn(
                name: "reservationnumber",
                table: "Facturen");
        }
    }
}
