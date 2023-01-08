using Microsoft.EntityFrameworkCore.Migrations;

namespace McLaren_Cardealer.Migrations
{
    public partial class ChangeDBSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auto_Wielen_WielenId",
                table: "Auto");

            migrationBuilder.DropForeignKey(
                name: "FK_AutoMotor_Auto_AutoId",
                table: "AutoMotor");

            migrationBuilder.DropForeignKey(
                name: "FK_AutoMotor_Motor_MotorId",
                table: "AutoMotor");

            migrationBuilder.DropForeignKey(
                name: "FK_Factuur_Auto_AutoId",
                table: "Factuur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Motor",
                table: "Motor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Factuur",
                table: "Factuur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutoMotor",
                table: "AutoMotor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Auto",
                table: "Auto");

            migrationBuilder.RenameTable(
                name: "Motor",
                newName: "Motoren");

            migrationBuilder.RenameTable(
                name: "Factuur",
                newName: "Facturen");

            migrationBuilder.RenameTable(
                name: "AutoMotor",
                newName: "AutoMotors");

            migrationBuilder.RenameTable(
                name: "Auto",
                newName: "Autos");

            migrationBuilder.RenameIndex(
                name: "IX_Factuur_AutoId",
                table: "Facturen",
                newName: "IX_Facturen_AutoId");

            migrationBuilder.RenameIndex(
                name: "IX_AutoMotor_MotorId",
                table: "AutoMotors",
                newName: "IX_AutoMotors_MotorId");

            migrationBuilder.RenameIndex(
                name: "IX_AutoMotor_AutoId",
                table: "AutoMotors",
                newName: "IX_AutoMotors_AutoId");

            migrationBuilder.RenameIndex(
                name: "IX_Auto_WielenId",
                table: "Autos",
                newName: "IX_Autos_WielenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Motoren",
                table: "Motoren",
                column: "MotorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facturen",
                table: "Facturen",
                column: "FactuurId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutoMotors",
                table: "AutoMotors",
                column: "AutoMotorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autos",
                table: "Autos",
                column: "AutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutoMotors_Autos_AutoId",
                table: "AutoMotors",
                column: "AutoId",
                principalTable: "Autos",
                principalColumn: "AutoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutoMotors_Motoren_MotorId",
                table: "AutoMotors",
                column: "MotorId",
                principalTable: "Motoren",
                principalColumn: "MotorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_Wielen_WielenId",
                table: "Autos",
                column: "WielenId",
                principalTable: "Wielen",
                principalColumn: "WielenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturen_Autos_AutoId",
                table: "Facturen",
                column: "AutoId",
                principalTable: "Autos",
                principalColumn: "AutoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutoMotors_Autos_AutoId",
                table: "AutoMotors");

            migrationBuilder.DropForeignKey(
                name: "FK_AutoMotors_Motoren_MotorId",
                table: "AutoMotors");

            migrationBuilder.DropForeignKey(
                name: "FK_Autos_Wielen_WielenId",
                table: "Autos");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturen_Autos_AutoId",
                table: "Facturen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Motoren",
                table: "Motoren");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facturen",
                table: "Facturen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autos",
                table: "Autos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutoMotors",
                table: "AutoMotors");

            migrationBuilder.RenameTable(
                name: "Motoren",
                newName: "Motor");

            migrationBuilder.RenameTable(
                name: "Facturen",
                newName: "Factuur");

            migrationBuilder.RenameTable(
                name: "Autos",
                newName: "Auto");

            migrationBuilder.RenameTable(
                name: "AutoMotors",
                newName: "AutoMotor");

            migrationBuilder.RenameIndex(
                name: "IX_Facturen_AutoId",
                table: "Factuur",
                newName: "IX_Factuur_AutoId");

            migrationBuilder.RenameIndex(
                name: "IX_Autos_WielenId",
                table: "Auto",
                newName: "IX_Auto_WielenId");

            migrationBuilder.RenameIndex(
                name: "IX_AutoMotors_MotorId",
                table: "AutoMotor",
                newName: "IX_AutoMotor_MotorId");

            migrationBuilder.RenameIndex(
                name: "IX_AutoMotors_AutoId",
                table: "AutoMotor",
                newName: "IX_AutoMotor_AutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Motor",
                table: "Motor",
                column: "MotorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Factuur",
                table: "Factuur",
                column: "FactuurId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auto",
                table: "Auto",
                column: "AutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutoMotor",
                table: "AutoMotor",
                column: "AutoMotorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auto_Wielen_WielenId",
                table: "Auto",
                column: "WielenId",
                principalTable: "Wielen",
                principalColumn: "WielenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutoMotor_Auto_AutoId",
                table: "AutoMotor",
                column: "AutoId",
                principalTable: "Auto",
                principalColumn: "AutoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutoMotor_Motor_MotorId",
                table: "AutoMotor",
                column: "MotorId",
                principalTable: "Motor",
                principalColumn: "MotorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Factuur_Auto_AutoId",
                table: "Factuur",
                column: "AutoId",
                principalTable: "Auto",
                principalColumn: "AutoId",
                onDelete: ReferentialAction.Cascade);

        }
    }
}
