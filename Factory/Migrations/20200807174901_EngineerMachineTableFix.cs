using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class EngineerMachineTableFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnigneerMachine_Engineers_EngineerId",
                table: "EnigneerMachine");

            migrationBuilder.DropForeignKey(
                name: "FK_EnigneerMachine_Machines_MachineId",
                table: "EnigneerMachine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnigneerMachine",
                table: "EnigneerMachine");

            migrationBuilder.RenameTable(
                name: "EnigneerMachine",
                newName: "EngineerMachine");

            migrationBuilder.RenameIndex(
                name: "IX_EnigneerMachine_MachineId",
                table: "EngineerMachine",
                newName: "IX_EngineerMachine_MachineId");

            migrationBuilder.RenameIndex(
                name: "IX_EnigneerMachine_EngineerId",
                table: "EngineerMachine",
                newName: "IX_EngineerMachine_EngineerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EngineerMachine",
                table: "EngineerMachine",
                column: "EngineerMachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachine_Engineers_EngineerId",
                table: "EngineerMachine",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachine_Machines_MachineId",
                table: "EngineerMachine",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachine_Engineers_EngineerId",
                table: "EngineerMachine");

            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachine_Machines_MachineId",
                table: "EngineerMachine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EngineerMachine",
                table: "EngineerMachine");

            migrationBuilder.RenameTable(
                name: "EngineerMachine",
                newName: "EnigneerMachine");

            migrationBuilder.RenameIndex(
                name: "IX_EngineerMachine_MachineId",
                table: "EnigneerMachine",
                newName: "IX_EnigneerMachine_MachineId");

            migrationBuilder.RenameIndex(
                name: "IX_EngineerMachine_EngineerId",
                table: "EnigneerMachine",
                newName: "IX_EnigneerMachine_EngineerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnigneerMachine",
                table: "EnigneerMachine",
                column: "EngineerMachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_EnigneerMachine_Engineers_EngineerId",
                table: "EnigneerMachine",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnigneerMachine_Machines_MachineId",
                table: "EnigneerMachine",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
